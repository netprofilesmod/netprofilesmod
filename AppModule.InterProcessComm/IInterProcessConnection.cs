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

namespace AppModule.InterProcessComm {
	#region Comments
	/// <summary>
	/// 
	/// </summary>
	#endregion
	public interface IInterProcessConnection : IDisposable {
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		int NativeHandle{get;}
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		void Connect();
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		void Close();
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		#endregion
		string Read();
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		#endregion
		byte[] ReadBytes();
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		#endregion
		void Write(string text);
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <param name="bytes"></param>
		#endregion
		void WriteBytes(byte[] bytes);
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		#endregion
		InterProcessConnectionState GetState();
	}
}