// Ignore Spelling: Utils Techex

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models
{
	using Newtonsoft.Json;

	/// <summary>
	/// Represents stream.
	/// </summary>
	public class Stream
	{
		/// <summary>
		/// Gets or sets the id of the stream.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the name of the stream.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether thumbnails are enabled for the stream.
		/// </summary>

		[JsonProperty("enableThumbnails")]
		public bool EnableThumbnails { get; set; }

		/// <summary>
		/// Gets or sets the options and configuration settings for the stream.
		/// </summary>
		[JsonProperty("options")]
		public StreamOptions Options { get; set; }
	}

}