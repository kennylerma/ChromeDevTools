using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows scroll bottleneck rects
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetShowScrollBottleneckRects)]
	public class SetShowScrollBottleneckRectsCommandResponse
	{
	}
}
