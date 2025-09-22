// Ignore Spelling: Utils Techex Failover Xoromt

namespace Utils.ConnectorAPI.Techex.MWCore.Models
{
	using Newtonsoft.Json;

	/// <summary>
	/// Represents the configuration options for a <see cref="Stream"/>.
	/// </summary>
	public class StreamOptions
	{
		/// <summary>
		/// Gets or sets the failover mode for the stream.
		/// </summary>
		[JsonProperty("failoverMode")]
		public string FailoverMode { get; set; }

		/// <summary>
		/// Gets or sets the amount of time (in seconds) after which the stream should revert 
		/// to its primary source when failover conditions are resolved.
		/// </summary>
		[JsonProperty("failoverRevertTime")]
		public int FailoverRevertTime { get; set; }

		/// <summary>
		/// Gets or sets the configured triggers that will cause a failover.
		/// </summary>
		[JsonProperty("failoverTriggers")]
		public FailoverTriggers FailoverTriggers { get; set; }

		/// <summary>
		/// Gets or sets the configured triggers that will mute the output.
		/// </summary>
		[JsonProperty("outputMuteTriggers")]
		public FailoverTriggers OutputMuteTriggers { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether XOR or OMT visualization should be shown.
		/// </summary>
		[JsonProperty("showXOROMT")]
		public bool ShowXoromt { get; set; }
	}
}