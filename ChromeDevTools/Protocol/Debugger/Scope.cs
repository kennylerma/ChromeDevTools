using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Scope description.
	/// </summary>
	public class Scope
	{
		/// <summary>
		/// Gets or sets Scope type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Object representing the scope. For <code>global</code> and <code>with</code> scopes it represents the actual object; for the rest of the scopes, it is artificial transient object enumerating scope variables as its properties.
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
	}
}
