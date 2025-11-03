namespace Utils.ConnectorAPI.Techex.MWCore.Models.MWEdge
{
	using Newtonsoft.Json;
	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models;
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Net.NetworkInformation;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// represents configuration for Basic MWEdge
	/// </summary>
	public class BasicMWEdge
	{
		/// <summary>
		/// Cloud License Configuration for the Edge
		/// </summary>
		[JsonProperty("cloudLicense")]
		public CloudLicense CloudLicense { get; set; }

		/// <summary>
		/// ID of the MWEdge
		/// </summary>
		[JsonProperty("_id")]
		public string Id { get; set; }

		/// <summary>
		/// ID of the Client
		/// </summary>
		[JsonProperty("clientId")]
		public string ClientId { get; set; }

		/// <summary>
		/// List of Sources configured on the Edge
		/// </summary>
		[JsonProperty("configuredSources")]
		public List<ConfiguredSource> ConfiguredSources { get; set; }

		/// <summary>
		/// List of Outputs configured on the Edge
		/// </summary>
		[JsonProperty("configuredOutputs")]
		public List<ConfiguredOutput> ConfiguredOutputs { get; set; }
	}

	/// <summary>
	/// Source Configuration for MWEdge
	/// </summary>
	public class ConfiguredSource : BasicSource
	{
		/// <summary>
		/// List of states for this source that may be active or not
		/// </summary>
		[JsonProperty("state")]
		public List<ConfigState> State { get; set; }
	}

	/// <summary>
	/// Output Configuration for MWEdge
	/// </summary>
	public class ConfiguredOutput : BasicOutput
	{
		/// <summary>
		/// List of states for this Output that may be active or not
		/// </summary>
		[JsonProperty("state")]
		public List<ConfigState> State { get; set; }
	}

	/// <summary>
	/// Configuration State
	/// </summary>
	public class ConfigState
	{
		/// <summary>
		/// Title of the state
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// Optional value that is specific to this state. E.g. when the error is about a buffer value, this is the buffer value being referenced. Can likely be ignored.
		/// </summary>
		[JsonProperty("value")]
		public object Value { get; set; }

		/// <summary>
		/// Whether the state is active or not
		/// </summary>
		[JsonProperty("active")]
		public bool? Active { get; set; }

		/// <summary>
		/// Boolean value whether this state is an error state or not. Will not be true the same time as "warning". If neither "error" or "warning" are true, then it's not an error or warning and is an information state.
		/// </summary>
		[JsonProperty("error")]
		public bool? Error { get; set; }

		/// <summary>
		/// Boolean value whether this state is a warning or not. Will not be true the same time as "error".
		/// </summary>
		[JsonProperty("warning")]
		public bool? Warning { get; set; }

		/// <summary>
		/// This is whether the user has acknowledged (dismissed) this state. Can be a string or a boolean. If a string it's ISO8601 date format e.g. "2024-12-04T10:53:01.389Z". If undefined, the state has not been acknowledged currently. If a boolean and equal to true, this state has been acknowledged indefinitely. When acknowledged we stop a state affecting the colour of our stream icon.
		/// </summary>
		[JsonProperty("acknowledgement")]
		public object Acknowledgement { get; set; }

		/// <summary>
		/// The time this state last happened. If the state is constantly currently active, for example for zero bitrate, this time will be when the state started and could be some considerable time in the past. This can be a string or an integer. If an integer it's the number of milliseconds since unix epoch (00:00 January 1st 1970). If a string it's in ISO8601 format e.g. "2024-12-04T10:35:51.530Z". If this value is 0 then the state has not yet happened since the last time the states/stats were reset or the process restarted.
		/// </summary>
		[JsonProperty("lastOccurrence")]
		public object LastOccurrence { get; set; }

		/// <summary>
		/// ID of the source state
		/// </summary>
		[JsonProperty("_id")]
		public string Id { get; set; }

		/// <summary>
		/// The time tx edge last logged this state.
		/// </summary>
		[JsonProperty("lastLogOccurrence")]
		public long? LastLogOccurrence { get; set; }
	}

	/// <summary>
	/// Cloud License Configuration for MWEdge
	/// </summary>
	public class CloudLicense
	{
		/// <summary>
		/// If cloud license is enabled, automatically request license via tx core. If disabled, you must license Edge with license key file
		/// </summary>
		[JsonProperty("enabled")]
		public bool? Enabled { get; set; }

		/// <summary>
		/// Array of cloud license pool configuration objects. Edge can have a license combined from multiple pools. Required if cloud license is enabled
		/// </summary>
		[JsonProperty("pools")]
		public List<Pool> Pools { get; set; }
	}

	/// <summary>
	/// Pool Configuration for Cloud License
	/// </summary>
	public class Pool
	{
		/// <summary>
		/// ID of the cloud license pool
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Number of units of the pool to request for the license for this Edge
		/// </summary>
		[JsonProperty("units")]
		public int? Units { get; set; }

		/// <summary>
		/// Size of each unit if the license pool in Mbps
		/// </summary>
		[JsonProperty("unitSize")]
		public double? UnitSize { get; set; }

		/// <summary>
		/// Name of the license pool
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The total requested usage of this license pool across all Edges on the Core (Mbps)
		/// </summary>
		[JsonProperty("usage")]
		public double? Usage { get; set; }

		/// <summary>
		/// The expiry date for the license pool. Expressed as milliseconds since 1st January 1970. A value of "-1" means no expiry date
		/// </summary>
		[JsonProperty("expires")]
		public long? Expires { get; set; }

		/// <summary>
		/// Total allowed maximum usage for this license pool across all Edges (Mbps). "-1" means unlimited
		/// </summary>
		[JsonProperty("value")]
		public double? Value { get; set; }
	}
}
