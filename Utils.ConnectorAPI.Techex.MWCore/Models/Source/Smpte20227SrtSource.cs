// Ignore Spelling: Utils Techex Srt Smpte

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models
{
	using Newtonsoft.Json;

	/// <summary>
	/// Represents an SRT-based SMPTE 2022-7 source configuration.
	/// </summary>
	public class Smpte20227SrtSource : SrtSourceOptions, I20227Source
	{
		/// <summary>
		/// Gets or sets a value indicating whether the source is enabled.
		/// </summary>
		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Gets or sets the protocol name used by the SRT source.
		/// </summary>
		[JsonProperty("protocol")]
		public string Protocol { get; set; }
	}
}