// Ignore Spelling: Utils Techex Failover Bitrate

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models
{
	using Newtonsoft.Json;

	/// <summary>
	/// Represents the set of conditions that can trigger failover or mute actions for a stream.
	/// </summary>
	public class FailoverTriggers
	{
		/// <summary>
		/// Gets or sets a value indicating whether CC errors within a period should trigger failover.
		/// </summary>
		[JsonProperty("CCErrorsInPeriod")]
		public bool CcErrorsInPeriod { get; set; }

		/// <summary>
		/// Gets or sets the threshold of CC errors within a period that triggers failover.
		/// </summary>
		[JsonProperty("CCErrorsInPeriodThreshold")]
		public int CcErrorsInPeriodThreshold { get; set; }

		/// <summary>
		/// Gets or sets the time window (in seconds) to evaluate CC errors for failover.
		/// </summary>
		[JsonProperty("CCErrorsInPeriodTime")]
		public int CcErrorsInPeriodTime { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether low bitrate should trigger failover.
		/// </summary>
		[JsonProperty("lowBitrate")]
		public bool LowBitrate { get; set; }

		/// <summary>
		/// Gets or sets the bitrate threshold below which failover is triggered.
		/// </summary>
		[JsonProperty("lowBitrateThreshold")]
		public int LowBitrateThreshold { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether missing packets in a period should trigger failover.
		/// </summary>
		[JsonProperty("missingPacketsInPeriod")]
		public bool MissingPacketsInPeriod { get; set; }

		/// <summary>
		/// Gets or sets the threshold of missing packets within a period that triggers failover.
		/// </summary>
		[JsonProperty("missingPacketsInPeriodThreshold")]
		public int MissingPacketsInPeriodThreshold { get; set; }

		/// <summary>
		/// Gets or sets the time window (in seconds) to evaluate missing packets for failover.
		/// </summary>
		[JsonProperty("missingPacketsInPeriodTime")]
		public int MissingPacketsInPeriodTime { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether transport stream sync loss should trigger failover.
		/// </summary>
		[JsonProperty("TSSyncLoss")]
		public bool? TsSyncLoss { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether zero bitrate should trigger failover.
		/// </summary>
		[JsonProperty("zeroBitrate")]
		public bool ZeroBitrate { get; set; }
	}

}