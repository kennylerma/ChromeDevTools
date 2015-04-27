using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[CommandResponse(ProtocolName.Input.SynthesizePinchGesture)]
	public class SynthesizePinchGestureCommandResponse
	{
	}
}
