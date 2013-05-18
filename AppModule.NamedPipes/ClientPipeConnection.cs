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
using System.IO;

using AppModule.InterProcessComm;

namespace AppModule.NamedPipes {
	#region Comments
	/// <summary>
	/// Used by client applications to communicate with server ones by using named pipes.
	/// </summary>
	#endregion
	public sealed class ClientPipeConnection : APipeConnection {
		#region Comments
		/// <summary>
		/// The network name of the server where the server pipe is created.
		/// </summary>
		/// <remarks>
		/// If "." is used as a server name then the pipe is connected to the local machine.
		/// </remarks>
		#endregion
		private string Server = ".";
		#region Comments
		/// <summary>
		/// Closes a client named pipe connection.
		/// </summary>
		/// <remarks>
		/// A client pipe connection is closed by closing the underlying pipe handle.
		/// </remarks>
		#endregion
		public override void Close() {
			CheckIfDisposed();
			NamedPipeWrapper.Close(this.Handle);
		}
		#region Comments
		/// <summary>
		/// Connects a client pipe to an existing server one.
		/// </summary>
		#endregion
		public override void Connect() {
			CheckIfDisposed();
			this.Handle = NamedPipeWrapper.ConnectToPipe(this.Name, this.Server);
		}
		#region Comments
		/// <summary>
		/// Attempts to establish a connection to the a server named pipe. 
		/// </summary>
		/// <remarks>
		/// If the attempt is successful the method creates the 
		/// <see cref="AppModule.NamedPipes.PipeHandle">PipeHandle</see> object
		/// and assigns it to the <see cref="AppModule.NamedPipes.APipeConnection.Handle">Handle</see>
		/// field.<br/><br/>
		/// This method is used when it is not known whether a server pipe already exists.
		/// </remarks>
		/// <returns>True if a connection is established.</returns>
		#endregion
		public bool TryConnect() {
			CheckIfDisposed();
			bool ReturnVal = NamedPipeWrapper.TryConnectToPipe(this.Name, this.Server, out this.Handle);

			return ReturnVal;
		}
		#region Comments
		/// <summary>
		/// Creates an instance of the ClientPipeConnection assuming that the server pipe
		/// is created on the same machine.
		/// </summary>
		/// <remarks>
		/// The maximum bytes to read from the client is set to be Int32.MaxValue.
		/// </remarks>
		/// <param name="name">The name of the server pipe.</param>
		#endregion
		public ClientPipeConnection(string name) {
			this.Name = name;
			this.Server = ".";
			this.maxReadBytes = Int32.MaxValue;
		}
		#region Comments
		/// <summary>
		/// Creates an instance of the ClientPipeConnection specifying the network name
		/// of the server.
		/// </summary>
		/// <remarks>
		/// The maximum bytes to read from the client is set to be Int32.MaxValue.
		/// </remarks>
		/// <param name="name">The name of the server pipe.</param>
		/// <param name="server">The network name of the machine, where the server pipe is created.</param>
		#endregion
		public ClientPipeConnection(string name, string server) {
			this.Name = name;
			this.Server = server;
			this.maxReadBytes = Int32.MaxValue;
		}
		#region Comments
		/// <summary>
		/// Object destructor.
		/// </summary>
		#endregion
		~ClientPipeConnection() {
			Dispose(false);
		}
	}
}