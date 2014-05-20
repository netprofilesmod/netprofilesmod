/*
Copyright 2004-2012 Hugo Anton Feldhammer, Urs Geissbühler, Daniel Milner


This file is part of Net Profiles mod.

Net Profiles mod is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Net Profiles mod is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Net Profiles mod.  If not, see <http://www.gnu.org/licenses/>.
*/

/*
Based on sample code released at http://www.codeproject.com/Articles/7176/Inter-Process-Communication-in-NET-Using-Named-Pip with no explicit license
*/

using System;
using System.Collections;
using System.Threading;
using System.Web;
using System.IO;
using System.Configuration;
using System.Diagnostics;

using AppModule.InterProcessComm;

namespace AppModule.NamedPipes {

	public sealed class PipeManager : IChannelManager {

		public Hashtable Pipes;
		public delegate void DebugMessage(string message);
		private DebugMessage DebugMessageRef;

		private uint NumberPipes = 5;
		private uint OutBuffer = 512;
		private uint InBuffer = 512;
		private const int MAX_READ_BYTES = 5000;
		private bool _listen = true;
		public bool Listen {
			get {
				return _listen;
			}
			set {
				_listen=value;
			}
		}
		private int numChannels = 0;
		private Hashtable _pipes = new Hashtable();
		private Thread MainThread;
		private string PipeName = "NetProfilesMod";
		private ManualResetEvent Mre;
		private const int PIPE_MAX_STUFFED_TIME = 5000;
		
		public object SyncRoot = new object();

		public void Initialize() {
			Pipes = Hashtable.Synchronized(_pipes);
			Mre = new ManualResetEvent(false);
			MainThread = new Thread(new ThreadStart(Start));
			MainThread.IsBackground = true;
			MainThread.Name = "Main Pipe Thread";
			MainThread.Start();
			Thread.Sleep(1000);
		}
		public string HandleRequest(string request) {
			string returnVal;

			if(DebugMessageRef != null) {
				DebugMessageRef(request + Environment.NewLine);
			}
			try {
				string[] profile = request.Split('|');
				AppModule.Globals.TcpIp.ApplyIp(profile[0], profile[1]);
				returnVal = "OK";
			}
			catch (Exception e) {
				returnVal = e.ToString();
			}
			

			return returnVal;
		}
		private void Start() {
			try {
				while (_listen) {
					int[] keys = new int[Pipes.Keys.Count];
					Pipes.Keys.CopyTo(keys,0);
					foreach (int key in keys) {
						ServerNamedPipe serverPipe = (ServerNamedPipe)Pipes[key];
						if (serverPipe != null && DateTime.Now.Subtract(serverPipe.LastAction).Milliseconds > PIPE_MAX_STUFFED_TIME && serverPipe.PipeConnection.GetState() != InterProcessConnectionState.WaitingForClient) {
							serverPipe.Listen = false;
							serverPipe.PipeThread.Abort();
							RemoveServerChannel(serverPipe.PipeConnection.NativeHandle);
						}
					}
					if (numChannels <= NumberPipes) {
						ServerNamedPipe pipe = new ServerNamedPipe(PipeName, OutBuffer, InBuffer, MAX_READ_BYTES, false, this);
						try {
							pipe.Connect();
							pipe.LastAction = DateTime.Now;
							System.Threading.Interlocked.Increment(ref numChannels);
							pipe.Start();
							Pipes.Add(pipe.PipeConnection.NativeHandle, pipe);
						}
						catch (InterProcessIOException) {
							RemoveServerChannel(pipe.PipeConnection.NativeHandle);
							pipe.Dispose();
						}
					}
					else {
						Mre.Reset();
						Mre.WaitOne(1000, false);
					}
				}
			}
			catch {
				// Log exception
			}
		}
		public void Stop() {
			_listen = false;
			Mre.Set();
			try {
				int[] keys = new int[Pipes.Keys.Count];
				Pipes.Keys.CopyTo(keys,0);
				foreach (int key in keys) {
					((ServerNamedPipe)Pipes[key]).Listen = false;
				}
				int i = numChannels * 3;
				for (int j = 0; j < i; j++) {
					StopServerPipe();
				}
				Pipes.Clear();
				Mre.Close();
				Mre = null;
			} 
			catch {	
				// Log exception
			}
		}

		public void WakeUp() {
			if (Mre != null) {
				Mre.Set();
			}
		}
		private void StopServerPipe() {
			try {
				ClientPipeConnection pipe = new ClientPipeConnection(PipeName);
				if (pipe.TryConnect()) {
					pipe.Close();
				}
			} catch {	
				// Log exception
			}
		}

		public void RemoveServerChannel(object param) {
			int handle = (int)param;
			System.Threading.Interlocked.Decrement(ref numChannels);
			Pipes.Remove(handle);
			this.WakeUp();
		}

		public PipeManager(): this(null) {
		}
		public PipeManager(DebugMessage activityRef) {
			DebugMessageRef = activityRef;
		}
	}
}