using System;
using System.IO;

namespace AppModule.InterProcessComm {
	#region Comments
	/// <summary>
	/// 
	/// </summary>
	#endregion
	public interface IClientChannel : IDisposable {
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		#endregion
		string HandleRequest(string request);
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		#endregion
		string HandleRequest(Stream request);
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		#endregion
		object HandleRequest(object request);
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		#endregion
		IClientChannel Create();
	}
}