// Ignore Spelling: Utils Techex SSRC Bitrate

using Newtonsoft.Json;

namespace Utils.ConnectorAPI.Techex.MWCore.Models
{
    /// <summary>
    /// Model to represent the UDP Source
    /// </summary>
    public class UdpSource : BasicSource
    {
        /// <summary>
        /// UDP Source configuration.
        /// </summary>
        [JsonProperty("options")]
        public UdpSourceOptions Options { get; set; }
    }

    /// <summary>
    /// Model to represent the UDP Source options
    /// </summary>
    public class UdpSourceOptions
    {
        /// <summary>
        /// IP Address of the Source. Only show when output type is Pull.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

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
        /// Start dropping packets if the bitrate on the backplane from this source exceeds this value.
        /// </summary>
        [JsonProperty("limitBitrate")]
        public bool LimitBitrate { get; set; }

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
        /// If an IP is defined the socket uses IGMPv3 SSM where possible. If IGMPv3 isn't supported, this filters traffic at application level.
        /// </summary>
        [JsonProperty("sourceAddress")]
        public object SourceAddress { get; set; }

        /// <summary>
        /// Set the output RTP SSRC when adding new RTP headers.
        /// Show when AddRTPHeaders enabled.
        /// </summary>
        [JsonProperty("ssrc")]
        public int? SSRC { get; set; }

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
        /// Add new RTP headers on to the stream before sending to the backplane.
        /// Show when AddRTPHeaders is true.
        /// </summary>
        [JsonProperty("addRTPHeaders")]
        public bool? AddRTPHeaders { get; set; }

        /// <summary>
        /// Indicates Transmission Type. <see cref="TransmissionTypes"/>
        /// </summary>
        [JsonProperty("transmission")]
        public int Transmission { get; set; }
    }
}