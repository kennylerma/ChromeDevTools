using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at given location specified either by URL or URL regex. Once this command is issued, all existing parsed scripts will have breakpoints resolved and returned in <code>locations</code> property. Further matching script parsing will result in subsequent <code>breakpointResolved</code> events issued. This logical breakpoint will survive page reloads.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpointByUrl)]
	public class SetBreakpointByUrlCommand
	{
		/// <summary>
		/// Gets or sets Line number to set breakpoint at.
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets URL of the resources to set breakpoint on.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Regex pattern for the URLs of the resources to set breakpoints on. Either <code>url</code> or <code>urlRegex</code> must be specified.
		/// </summary>
		public string UrlRegex { get; set; }
		/// <summary>
		/// Gets or sets Offset in the line to set breakpoint at.
		/// </summary>
		public long ColumnNumber { get; set; }
		/// <summary>
		/// Gets or sets Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.
		/// </summary>
		public string Condition { get; set; }
	}
}
