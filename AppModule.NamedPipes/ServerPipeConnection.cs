using System;
using System.IO;

using AppModule.InterProcessComm;

namespace AppModule.NamedPipes {
	#region Comments
	/// <summary>
	/// Used by server applications to communicate with client ones by using named pipes.
	/// </summary>
	#endregion
	public sealed class ServerPipeConnection : APipeConnection {
		#region Comments
		/// <summary>
		/// Disconnects a client named pipe.
		/// </summary>
		/// <remarks>
		/// When a client named pipe is disconnected, the server one is not closed. 
		/// The latter can later be reused by starting to listen again.<br/><br/>
		/// In a message oriented protocol the server will disconnect the client when the 
		/// response is sent and all the data is flushed. The same server named pipe 
		/// could then be reused by calling the 
		/// <see cref="AppModule.NamedPipes.ServerPipeConnection.Connect">Connect</see> method.
		/// </remarks>
		#endregion
		public void Disconnect() {
			CheckIfDisposed();
			NamedPipeWrapper.Disconnect(this.Handle);
		}
		#region Comments
		/// <summary>
		/// Closes the operating system native handle of the named pipe.
		/// </summary>
		#endregion
		public override void Close() {
			CheckIfDisposed();
			NamedPipeWrapper.Close(this.Handle);
		}
		#region Comments
		/// <summary>
		/// Starts listening to client pipe connections.
		/// </summary>
		/// <remarks>
		/// This method will block the program execution until a client pipe attempts
		/// to establish a connection.<br/><br/>
		/// When a client named pipe is disconnected, the server one is not closed. 
		/// The latter can later be reused by starting to listen again.<br/><br/>
		/// </remarks>
		#endregion
		public override void Connect() {
			CheckIfDisposed();
			NamedPipeWrapper.Connect(this.Handle);
		}
		#region Comments
		/// <summary>
		/// Creates a ServerPipeConnection instance and the underlying operating system handle.
		/// </summary>
		/// <param name="name">The name of the pipe.</param>
		/// <param name="outBuffer">The outbound buffer.</param>
		/// <param name="inBuffer">The inbound buffer.</param>
		/// <param name="maxReadBytes">The maximum bytes to read from clients.</param>
		#endregion
		public ServerPipeConnection(string name, uint outBuffer, uint inBuffer, int maxReadBytes) {
			this.Name = name;
			this.Handle = NamedPipeWrapper.Create(name, outBuffer, inBuffer, true);
			this.maxReadBytes = maxReadBytes;
		}
		#region Comments
		/// <summary>
		/// Creates a ServerPipeConnection instance and the underlying operating system handle.
		/// </summary>
		/// <param name="name">The name of the pipe.</param>
		/// <param name="outBuffer">The outbound buffer.</param>
		/// <param name="inBuffer">The inbound buffer.</param>
		/// <param name="secure">Specifies whether the pipe is secure.</param>
		/// <param name="maxReadBytes">The maximum bytes to read from clients.</param>
		/// <remarks>If the <b>secure</b> parameter is true the default security descriptor is used. The ACLs in the default security descriptor for a named pipe grant full control to the LocalSystem account, administrators, and the creator owner. They also grant read access to members of the Everyone group and the anonymous account.
		/// <br/><br/>
		/// If the <b>secure</b> parameter is false the method creates a security descriptor that grants full access to Everyone.
		/// </remarks>
		#endregion
		public ServerPipeConnection(string name, uint outBuffer, uint inBuffer, int maxReadBytes, bool secure) {
			this.Name = name;
			this.Handle = NamedPipeWrapper.Create(name, outBuffer, inBuffer, secure);
			this.maxReadBytes = maxReadBytes;
		}
		#region Comments
		/// <summary>
		/// Object destructor.
		/// </summary>
		#endregion
		~ServerPipeConnection() {
			Dispose(false);
		}
	}
}