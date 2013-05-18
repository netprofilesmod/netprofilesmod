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
using System.Runtime.Serialization;

using AppModule.InterProcessComm;

namespace AppModule.NamedPipes {
	#region Comments
	/// <summary>
	/// This exception is thrown by named pipes communication methods.
	/// </summary>
	#endregion
	public class NamedPipeIOException : InterProcessIOException {
		#region Comments
		/// <summary>
		/// Creates a NamedPipeIOException instance.
		/// </summary>
		/// <param name="text">The error message text.</param>
		#endregion
		public NamedPipeIOException(String text) : base(text) {
		}
		#region Comments
		/// <summary>
		/// Creates a NamedPipeIOException instance.
		/// </summary>
		/// <param name="text">The error message text.</param>
		/// <param name="errorCode">The native error code.</param>
		#endregion
		public NamedPipeIOException(String text, uint errorCode) : base(text) {
			this.ErrorCode = errorCode;
			if (errorCode == NamedPipeNative.ERROR_CANNOT_CONNECT_TO_PIPE) {
				this.IsServerAvailable = false;
			}
		}
		#region Comments
		/// <summary>
		/// Creates a NamedPipeIOException instance.
		/// </summary>
		/// <param name="info">The serialization information.</param>
		/// <param name="context">The streaming context.</param>
		#endregion
		protected NamedPipeIOException(SerializationInfo info, StreamingContext context) : base(info, context) {
		}
	}
}