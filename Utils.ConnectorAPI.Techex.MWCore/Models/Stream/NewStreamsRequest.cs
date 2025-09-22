// Ignore Spelling: Utils Techex

namespace Utils.ConnectorAPI.Techex.MWCore.Models
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Serialization;

	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models;

	/// <summary>
	/// Represents a request to create one or more streams, including their sources and outputs.
	/// </summary>
	public class NewStreamsRequest
	{
		/// <summary>
		/// Gets or sets the collection of streams to be created.
		/// Setting an id for each stream is required for linking the sources and outputs.
		/// </summary>
		[JsonProperty("streams")]
		public Stream[] Streams { get; set; }

		/// <summary>
		/// Gets or sets the collection of input sources associated with the streams.
		/// Stream id is required.
		/// </summary>
		[JsonProperty("sources")]
		public BasicSource[] Sources { get; set; }

		/// <summary>
		/// Gets or sets the collection of outputs associated with the streams.
		/// Stream id is required.
		/// </summary>
		[JsonProperty("outputs")]
		public BasicOutput[] Outputs { get; set; }
	}
}