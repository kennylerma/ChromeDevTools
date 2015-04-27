using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Detailed application cache information.
	/// </summary>
	public class ApplicationCache
	{
		/// <summary>
		/// Gets or sets Manifest URL.
		/// </summary>
		public string ManifestURL { get; set; }
		/// <summary>
		/// Gets or sets Application cache size.
		/// </summary>
		public double Size { get; set; }
		/// <summary>
		/// Gets or sets Application cache creation time.
		/// </summary>
		public double CreationTime { get; set; }
		/// <summary>
		/// Gets or sets Application cache update time.
		/// </summary>
		public double UpdateTime { get; set; }
		/// <summary>
		/// Gets or sets Application cache resources.
		/// </summary>
		public ApplicationCacheResource[] Resources { get; set; }
	}
}
