// Ignore Spelling: Bitrate Ssrc Fec Utils Techex Rtp

using Newtonsoft.Json;

namespace Utils.ConnectorAPI.Techex.MWCore.Models
{
    /// <summary>
    /// Model to represent the RTP Source
    /// </summary>
    public class RtpSource : BasicSource
    {
        /// <summary>
        /// RTP Source source configuration.
        /// </summary>
        [JsonProperty("options")]
        public RtpSourceOptions Options { get; set; }
    }

    /// <summary>
    /// Model to represent the RTP Source source options
    /// </summary>
    public class RtpSourceOptions
    {
        /// <summary>
        /// IP Address of the Source. Only show when output type is Pull.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Enable correction of RTP stream (pacing, re-ordering, and removal of duplicates) which requires buffering of the packets.
        /// Disabling this passes all packets through with a reduced set of statistics and zero buffering.
        /// Show when Enable Correction is enabled.
        /// </summary>
        [JsonProperty("buffer")]
        public int? Buffer { get; set; }

        /// <summary>
        /// The even key to use when decrypting the MPEGTS.
        /// </summary>
        [JsonProperty("decryptionEvenKey")]
        public object DecryptionEvenKey { get; set; }

        /// <summary>
        /// The odd key to use when decrypting the MPEGTS.
        /// </summary>
        [JsonProperty("decryptionOddKey")]
        public object DecryptionOddKey { get; set; }

        /// <summary>
        /// The standard to use when decrypting the MPEGTS.
        /// Values: None = null, BISS2 Mode-1 = BISS2 Mode-1
        /// </summary>
        [JsonProperty("decryptionType")]
        public object DecryptionType { get; set; }

        /// <summary>
        /// Enable correction of RTP stream (pacing, re-ordering, and removal of duplicates) which requires buffering of the packets.
        /// Disabling this passes all packets through with a reduced set of statistics and zero buffering.
        /// </summary>
        [JsonProperty("enableCorrection")]
        public bool EnableCorrection { get; set; }

        /// <summary>
        /// Filter out RTP SSRC or pass through all.
        /// </summary>
        [JsonProperty("filterSsrc")]
        public int? FilterSsrc { get; set; }

        /// <summary>
        /// Start dropping packets if the bitrate on the backplane from this source exceeds this value.
        /// </summary>
        [JsonProperty("limitBitrate")]
        public bool LimitBitrate { get; set; }

        /// <summary>
        /// Drop packets on the backplane when the bitrate exceeds this rate.
        /// Show when LimitBitrate is true.
        /// </summary>
        [JsonProperty("maxBitrateLimit")]
        public int? MaxBitrateLimit { get; set; }

        /// <summary>
        /// What to do if the backplane bitrate exceeds the maximum limit set.
        /// Show when LimitBitrate is true.
        /// </summary>
        [JsonProperty("bitrateCappingEvent")]
        public string BitrateCappingEvent { get; set; }

        /// <summary>
        /// The IP of the interface to receive the stream on.
        /// </summary>
        [JsonProperty("networkInterface")]
        public string NetworkInterface { get; set; }

        /// <summary>
        /// Port currently in use by the Source.
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// Retain original RTP headers to allow seamless switching.
        /// </summary>
        [JsonProperty("preserveHeaders")]
        public bool PreserveHeaders { get; set; }

        /// <summary>
        /// If an IP is defined the socket uses IGMPv3 SSM where possible. If IGMPv3 isn't supported, this filters traffic at application level.
        /// </summary>
        [JsonProperty("sourceAddress")]
        public object SourceAddress { get; set; }

        /// <summary>
        /// Indicates Transmission Type. <see cref="TransmissionTypes"/>
        /// </summary>
        [JsonProperty("transmission")]
        public int Transmission { get; set; }

        /// <summary>
        /// Enable forward error correction based on the ST 2022-1 specification (level B, non-block aligned).
        /// Show when Enable Correction is enabled.
        /// </summary>
        [JsonProperty("useFEC")]
        public bool Fec { get; set; }

        /// <summary>
		/// FEC Column Port
        /// Show when FEC is enabled.
		/// </summary>
		[JsonProperty("fecColumnPort")]
        public int? FecColumnPort { get; set; }

        /// <summary>
		/// FEC Row Port
        /// Show when FEC is enabled.
		/// </summary>
		[JsonProperty("fecRowPort")]
        public int? FecRowPort { get; set; }
    }
}