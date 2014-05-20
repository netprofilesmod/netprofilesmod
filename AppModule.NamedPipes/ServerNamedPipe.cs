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
using System.Threading;
using System.IO;

using AppModule.InterProcessComm;

namespace AppModule.NamedPipes {

	public sealed class ServerNamedPipe : IDisposable {
		internal Thread PipeThread;
		internal ServerPipeConnection PipeConnection;
		internal bool Listen = true;
		internal DateTime LastAction;
		private bool disposed = false;
		public static IChannelManager PipeManager;
		public delegate void DebugMessage(string message);
		private DebugMessage DebugMessageRef;

		private void PipeListener() {
			CheckIfDisposed();
			try {
				Listen = PipeManager.Listen;
				if(DebugMessageRef != null) {
					DebugMessageRef("Pipe " + this.PipeConnection.NativeHandle.ToString() + ": new pipe started" + Environment.NewLine);
				}
				while (Listen) {
					LastAction = DateTime.Now;
					string request = PipeConnection.Read();
					LastAction = DateTime.Now;
					if (request.Trim() != "") {
						PipeConnection.Write(PipeManager.HandleRequest(request));
						if(DebugMessageRef != null) {
							DebugMessageRef("Pipe " + this.PipeConnection.NativeHandle.ToString() + ": request handled" + Environment.NewLine);
						}
					}
					else {
						PipeConnection.Write("Error: bad request");
					}
					LastAction = DateTime.Now;
					PipeConnection.Disconnect();
					if (Listen) {
						if(DebugMessageRef != null) {
							DebugMessageRef("Pipe " + this.PipeConnection.NativeHandle.ToString() + ": listening" + Environment.NewLine);
						}
						Connect();
					}
					PipeManager.WakeUp();
				}
			} 
			catch (System.Threading.ThreadAbortException) { }
			catch (System.Threading.ThreadStateException) { }
			catch (Exception) { 
				// Log exception
			}
			finally {
				this.Close();
			}
		}
		internal void Connect() {
			CheckIfDisposed();
			PipeConnection.Connect();
		}
		internal void Close() {
			CheckIfDisposed();
			this.Listen = false;
			PipeManager.RemoveServerChannel(this.PipeConnection.NativeHandle);
			this.Dispose();
		}
		internal void Start() {
			CheckIfDisposed();
			PipeThread.Start();
		}
		private void CheckIfDisposed() {
			if(this.disposed) {
				throw new ObjectDisposedException("ServerNamedPipe");
			}
		}
		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		private void Dispose(bool disposing) {
			if(!this.disposed) {
				PipeConnection.Dispose();
				if (PipeThread != null) {
					try {
						PipeThread.Abort();
					} 
					catch (System.Threading.ThreadAbortException) { }
					catch (System.Threading.ThreadStateException) { }
					catch (Exception) {
						// Log exception
					}
				}
			}
			disposed = true;         
		}
		~ServerNamedPipe() {
			Dispose(false);
		}
		internal ServerNamedPipe(string name, uint outBuffer, uint inBuffer, int maxReadBytes, bool secure, IChannelManager pipeManager): this(name, outBuffer, inBuffer, maxReadBytes, secure, pipeManager, null) {
		}
		internal ServerNamedPipe(string name, uint outBuffer, uint inBuffer, int maxReadBytes, bool secure, IChannelManager pipeManager, DebugMessage activityRef) {
			DebugMessageRef = activityRef;
			PipeManager = pipeManager;
			PipeConnection = new ServerPipeConnection(name, outBuffer, inBuffer, maxReadBytes, secure);
			PipeThread = new Thread(new ThreadStart(PipeListener));
			PipeThread.IsBackground = true;
			PipeThread.Name = "Pipe Thread " + this.PipeConnection.NativeHandle.ToString();
			LastAction = DateTime.Now;
		}
	}
}