// Ignore Spelling: Utils Techex Mwedge

using Newtonsoft.Json;

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models
{
    /// <summary>
    /// Basic Output model. (Without options configuration)
    /// </summary>
    public class BasicOutput
    {
        /// <summary>
        /// Output ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Output name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the output is paused or not.
        /// </summary>
        [JsonProperty("paused")]
        public bool Paused { get; set; }

        /// <summary>
        /// Indicates the output protocol.
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Indicates the stream ID where the output belongs.
        /// </summary>
        [JsonProperty("stream")]
        public string Stream { get; set; }

        /// <summary>
        /// Indicates the MWEdge ID where the output belongs.
        /// </summary>
        [JsonProperty("mwedge")]
        public string Mwedge { get; set; }
    }
}