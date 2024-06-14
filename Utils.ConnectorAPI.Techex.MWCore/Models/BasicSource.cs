// Ignore Spelling: Techex Utils Etr Mwedge

using Newtonsoft.Json;

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models
{
    /// <summary>
    /// Basic Input model. (Without options configuration)
    /// </summary>
    public class BasicSource
    {
        /// <summary>
        /// The state of the input relative to the output on the stream.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Enable/Disable ETR 290.
        /// </summary>
        [JsonProperty("etr290Enabled")]
        public bool Etr290Enabled { get; set; }

        /// <summary>
        /// Indicates the new Exhausted state for the current Input Source.
        /// Note that this option is only used when the stream Failover mode is set to "Once".
        /// </summary>
        [JsonProperty("exhausted")]
        public bool Exhausted { get; set; }

        /// <summary>
        /// Input Source ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Indicates the MWEdge ID where the input source belongs.
        /// </summary>
        [JsonProperty("mwedge")]
        public string Mwedge { get; set; }

        /// <summary>
        /// Input Source name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether it's currently in used to pull Inactive Sources (Only When Active) or not (Always Pull Stream).
        /// Note that this option can be used in order to save resource/bandwidth.
        /// </summary>
        [JsonProperty("passive")]
        public bool Passive { get; set; }

        /// <summary>
        /// Indicates whether the Input Source is Paused or Resumed.
        /// </summary>
        [JsonProperty("paused")]
        public bool Paused { get; set; }

        /// <summary>
        /// Displays the order in which the Sources will Failover/Revert.
        /// The lower the numerical value, the higher the Priority.
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Displays the Protocol currently in use by the Input Source.
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Indicates the stream ID where the input source belongs.
        /// </summary>
        [JsonProperty("stream")]
        public string Stream { get; set; }
    }
}