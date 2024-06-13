// Ignore Spelling: Srt Bitrate Fec Arq Passphrase SSRC Techex Utils

using Newtonsoft.Json;

namespace Utils.ConnectorAPI.Techex.MWCore.Models
{
    /// <summary>
    /// Model to represent the SRT Source
    /// </summary>
    public class SrtSource : BasicSource
    {
        /// <summary>
        /// SRT Source configuration.
        /// </summary>
        [JsonProperty("options")]
        public SrtSourceOptions Options { get; set; }
    }

    /// <summary>
    /// Model to represent the SRT Source options
    /// </summary>
    public class SrtSourceOptions
    {
        /// <summary>
        /// IP Address of the Source. Only show when output type is Pull.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Size of the chunk currently in use is UDP, RTP or custom. <see cref="ChunkSizes"/>
        /// </summary>
        [JsonProperty("chunkSize")]
        public int ChunkSize { get; set; }

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
        /// The SRT encryption key length shared between the source and the output.
        /// <see cref="TransportEncryptions"/>
        /// </summary>
        [JsonProperty("encryption")]
        public int Encryption { get; set; }

        /// <summary>
        /// FEC re-request behaviour.
        /// Values: Only FEC = never, After FEC = onreq, Simultaneous = always.
        /// </summary>
        [JsonProperty("fecArq")]
        public string FecArq { get; set; }

        /// <summary>
		/// Number of columns in the FEC matrix: Lower values protect against burst loss but increase the FEC overhead.
		/// </summary>
		[JsonProperty("fecColumns")]
        public int? FecColumns { get; set; }

        /// <summary>
        /// Enable Forward Error Correction.
        /// </summary>
        [JsonProperty("fecEnabled")]
        public bool FecEnabled { get; set; }

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
        /// Block-alignment of the FEC matrix".
        /// Values: Staircase = staircase, Even = even.
        /// </summary>
        [JsonProperty("fecLayout")]
        public string FecLayout { get; set; }

        /// <summary>
        /// Number of rows in the FEC matrix: Lower values protect against random loss but increase the FEC overhead.
        /// </summary>
        [JsonProperty("fecRows")]
        public int? FecRows { get; set; }

        /// <summary>
        /// Remove any RTP headers from the incoming stream after the SRT protocol.
        /// Show when ChunkSize is RTP.
        /// </summary>
        [JsonProperty("removeRTPHeaders")]
        public bool? RemoveRTPHeaders { get; set; }

        /// <summary>
        /// Add new RTP headers on to the stream before sending to the backplane.
        /// Show when AddRTPHeaders is true.
        /// </summary>
        [JsonProperty("addRTPHeaders")]
        public bool? AddRTPHeaders { get; set; }

        /// <summary>
        /// Set the output RTP SSRC when adding new RTP headers.
        /// Show when ChunkSize is SRT.
        /// </summary>
        [JsonProperty("ssrc")]
        public int? SSRC { get; set; }

        /// <summary>
        /// Host Address currently in use by the Source.
        /// </summary>
        [JsonProperty("hostAddress")]
        public object HostAddress { get; set; }

        /// <summary>
        /// The latency value should be a buffer period in milliseconds large enough to cover the time spent for sending, extended RTT time, and the time needed to retransmit lost packets.
        /// Buffer value used is max of values set at receiver and sender.
        /// </summary>
        [JsonProperty("latency")]
        public int Latency { get; set; }

        /// <summary>
        /// Indicates which Logging level is currently used by the Source.
        /// <see cref="OutputLogLevels"/>
        /// </summary>
        [JsonProperty("logLevel")]
        public int LogLevel { get; set; }

        /// <summary>
        /// The SRT passphrase is the shared secret between the source and the output.
        /// Only used when establishing a new connection, changing it will not disrupt existing ones.
        /// Length 10 to 79 characters.
        /// </summary>
        [JsonProperty("passphrase")]
        public string Passphrase { get; set; }

        /// <summary>
        /// Port currently in use by the Source.
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// IPv4 Type of Service or IPv6 Traffic Class. Can be used for QOS.
        /// </summary>
        [JsonProperty("serviceType")]
        public int ServiceType { get; set; }

        /// <summary>
        /// IPv4 Time To Live or IPv6 unicast hops.
        /// </summary>
        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        /// <summary>
        /// Indicates whether the type is 'Listener' or 'Push'.
        /// Note that this option is only available for Source Sources using the SRT protocol. <see cref="SRTSourceType"/>
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
    }
}