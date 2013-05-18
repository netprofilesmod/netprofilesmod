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
	public enum InterProcessConnectionState {
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		NotSet = 0,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Error = 1,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Creating = 2,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Created = 3,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		WaitingForClient = 4,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		ConnectedToClient = 5,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		ConnectingToServer = 6,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		ConnectedToServer = 7,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Reading = 8,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		ReadData = 9,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Writing = 10,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		WroteData = 11,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Flushing = 12,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		FlushedData = 13,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Disconnecting = 14,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Disconnected = 15,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Closing = 16,
		#region Comments
		/// <summary>
		/// 
		/// </summary>
		#endregion
		Closed = 17,
	}
}