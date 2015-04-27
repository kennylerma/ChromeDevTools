using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// This method sends a new XMLHttpRequest which is identical to the original one. The following parameters should be identical: method, url, async, request body, extra headers, withCredentials attribute, user, password.
	/// </summary>
	[Command(ProtocolName.Network.ReplayXHR)]
	public class ReplayXHRCommand
	{
		/// <summary>
		/// Gets or sets Identifier of XHR to replay.
		/// </summary>
		public string RequestId { get; set; }
	}
}
