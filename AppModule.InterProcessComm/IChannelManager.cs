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
	/// Interface, which defines methods for a Channel Manager class.
	/// </summary>
	/// <remarks>
	/// A Channel Manager is responsible for creating and maintaining channels for inter-process communication. The opened channels are meant to be reusable for performance optimization. Each channel needs to procees requests by calling the <see cref="AppModule.InterProcessComm.IChannelManager.HandleRequest">HandleRequest</see> method of the Channel Manager.
	/// </remarks>
	#endregion
	public interface IChannelManager {
		#region Comments
		/// <summary>
		/// Initializes the Channel Manager.
		/// </summary>
		#endregion
		void Initialize();
		#region Comments
		/// <summary>
		/// Closes all opened channels and stops the Channel Manager.
		/// </summary>
		#endregion
		void Stop();
		#region Comments
		/// <summary>
		/// Handles a request.
		/// </summary>
		/// <remarks>
		/// This method currently caters for text based requests. XML strings can be used in case complex request structures are needed.
		/// </remarks>
		/// <param name="request">The incoming request.</param>
		/// <returns>The resulting response.</returns>
		#endregion
		string HandleRequest(string request);
		#region Comments
		/// <summary>
		/// Indicates whether the Channel Manager is in listening mode.
		/// </summary>
		/// <remarks>
		/// This property is left public so that other classes, like a server channel can start or stop listening based on the Channel Manager mode.
		/// </remarks>
		#endregion
		bool Listen {get; set;}
		#region Comments
		/// <summary>
		/// Forces the Channel Manager to exit a sleeping mode and create a new channel.
		/// </summary>
		/// <remarks>
		/// Normally the Channel Manager will create a number of reusable channels, which will handle the incoming reqiests, and go into a sleeping mode. However if the request load is high, the Channel Manager needs to be asked to create additional channels.
		/// </remarks>
		#endregion
		void WakeUp();
		#region Comments
		/// <summary>
		/// Removes an existing channel.
		/// </summary>
		/// <param name="param">A parameter identifying the channel.</param>
		#endregion
		void RemoveServerChannel(object param);
	}
}
