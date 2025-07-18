// Ignore Spelling: Smpte Bitrate Etr Tcap Utils Techex

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models
{
	using Newtonsoft.Json;

	/// <summary>
	/// Represents a generic 2022-7 SMPTE source.
	/// </summary>
	public interface I20227Source
	{
		/// <summary>
		/// Gets or sets a value indicating whether the source is enabled.
		/// </summary>
		bool Enabled { get; set; }

		/// <summary>
		/// Gets or sets the protocol used by the source.
		/// </summary>
		string Protocol { get; set; }
	}

	/// <summary>
	/// Represents a specific configuration for a 2022-7 source.
	/// </summary>
	public class Smpte20227Source
	{
		/// <summary>
		/// Gets or sets the name of the source.
		/// </summary>
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }

		/// <summary>
		/// Indicates the stream ID where the input source belongs.
		/// </summary>
		[JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
		public string Stream { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the source is passive.
		/// </summary>
		[JsonProperty("passive", NullValueHandling = NullValueHandling.Ignore)]
		public bool? PassiveSource { get; set; }

		/// <summary>
		/// Gets or sets additional options for the source.
		/// </summary>
		[JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
		public Smpte20227Options Options { get; set; }

		/// <summary>
		/// Gets or sets the protocol used by the source.
		/// </summary>
		[JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
		public string Protocol { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the source is paused.
		/// </summary>
		[JsonProperty("paused", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Paused { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the source is active.
		/// </summary>
		[JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Active { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether ETR-290 monitoring is enabled.
		/// </summary>
		[JsonProperty("etr290Enabled", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Etr290Enabled { get; set; }

		/// <summary>
		/// Gets or sets the priority of the source.
		/// </summary>
		[JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
		public int Priority { get; set; }
	}

	/// <summary>
	/// Represents extended configuration options for a 2022-7 source.
	/// </summary>
	public class Smpte20227Options
	{
		/// <summary>
		/// Gets or sets the buffer size.
		/// </summary>
		[JsonProperty("buffer", NullValueHandling = NullValueHandling.Ignore)]
		public int Buffer { get; set; }

		/// <summary>
		/// Gets or sets the type of source.
		/// </summary>
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the primary source configuration.
		/// </summary>
		[JsonProperty("sourceOne", NullValueHandling = NullValueHandling.Ignore)]
		public I20227Source SourceOne { get; set; }

		/// <summary>
		/// Gets or sets the decryption type.
		/// </summary>
		[JsonProperty("decryptionType", NullValueHandling = NullValueHandling.Ignore)]
		public object DecryptionType { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to limit the bitrate.
		/// </summary>
		[JsonProperty("limitBitrate", NullValueHandling = NullValueHandling.Ignore)]
		public bool LimitBitrate { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether to re-pad TS null packets.
		/// </summary>
		[JsonProperty("rePadTSNulls", NullValueHandling = NullValueHandling.Ignore)]
		public bool RePadTSNulls { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether TCAP processing is enabled.
		/// </summary>
		[JsonProperty("tcap", NullValueHandling = NullValueHandling.Ignore)]
		public bool Tcap { get; set; }

		/// <summary>
		/// Gets or sets the secondary source configuration.
		/// </summary>
		[JsonProperty("sourceTwo", NullValueHandling = NullValueHandling.Ignore)]
		public I20227Source SourceTwo { get; set; }

		/// <summary>
		/// Gets or sets the tertiary source configuration.
		/// </summary>
		[JsonProperty("sourceThree", NullValueHandling = NullValueHandling.Ignore)]
		public I20227Source SourceThree { get; set; }
	}
}