using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given the JavaScript node object reference. All nodes that form the path from the node to the root are also sent to the client as a series of <code>setChildNodes</code> notifications.
	/// </summary>
	[Command(ProtocolName.DOM.RequestNode)]
	public class RequestNodeCommand
	{
		/// <summary>
		/// Gets or sets JavaScript object id to convert into node.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
