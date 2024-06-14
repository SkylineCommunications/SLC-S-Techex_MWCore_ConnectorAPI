// Ignore Spelling: Utils Techex Srt Passphrase

using Newtonsoft.Json;

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models
{
    /// <summary>
    /// Model to represent the SRT Output
    /// </summary>
    public class SrtOutput : BasicOutput
    {
        /// <summary>
        /// SRT Output configuration.
        /// </summary>
        [JsonProperty("options")]
        public SrtOutputOptions Options { get; set; }
    }

    /// <summary>
    /// Model to represent the SRT Output Options
    /// </summary>
    public class SrtOutputOptions
    {
        /// <summary>
        /// IP Address of the Output. Only show when output type is Push.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Size of the chunk currently in use is UDP, RTP or custom. <see cref="ChunkSizes"/>
        /// </summary>
        [JsonProperty("chunkSize")]
        public int ChunkSize { get; set; }

        /// <summary>
        /// The SRT encryption key length shared between the source and the output.
        /// <see cref="TransportEncryptions"/>
        /// </summary>
        [JsonProperty("encryption")]
        public int Encryption { get; set; }

        /// <summary>
        /// The even key to use when encrypting the MPEGTS.
        /// </summary>
        [JsonProperty("encryptionEvenKey")]
        public string EncryptionEvenKey { get; set; }

        /// <summary>
        /// The key to use when encrypting the MPEGTS.
        /// Values: Odd = odd, Even = even
        /// </summary>
        [JsonProperty("encryptionKeyParity")]
        public string EncryptionKeyParity { get; set; }

        /// <summary>
        /// The odd key to use when encrypting the MPEGTS.
        /// </summary>
        [JsonProperty("encryptionOddKey")]
        public string EncryptionOddKey { get; set; }

        /// <summary>
        /// Percent of packets to encrypt.
        /// Percentage is rounded up to a value divisible by 6.25 to ensure that multiple processes/MWEdges encrypt a stream in the same way for security reasons.
        /// </summary>
        [JsonProperty("encryptionPercentage")]
        public int EncryptionPercentage { get; set; }

        /// <summary>
        /// The standard to use when encrypting the MPEGTS. If passing through RTP headers, BISS will not add the scrambling descriptor to the PMT.
        /// Values: None = null, BISS2 Mode-1 = BISS2 Mode-1
        /// </summary>
        [JsonProperty("encryptionType")]
        public object EncryptionType { get; set; }

        /// <summary>
        /// Host Address currently in use by the Output.
        /// </summary>
        [JsonProperty("hostAddress")]
        public object HostAddress { get; set; }

        /// <summary>
        /// The latency value should be a buffer period in milliseconds large enough to retransmit any lost packets.
        /// Buffer value used is max of values set at sender and receiver (Use receiver latency = 0).
        /// </summary>
        [JsonProperty("latency")]
        public int Latency { get; set; }

        /// <summary>
        /// Indicates which Logging level is currently used by the Output.
        /// <see cref="OutputLogLevels"/>
        /// </summary>
        [JsonProperty("logLevel")]
        public int LogLevel { get; set; }

        /// <summary>
        /// Limit of the bandwidth in bits per second (Automatic = 0).
        /// </summary>
        [JsonProperty("maxBandwidth")]
        public int MaxBandwidth { get; set; }

        /// <summary>
        /// Limits the number of SRT connections for this Output (Unlimited = 0).
        /// Only show when output type is Listener.
        /// </summary>
        [JsonProperty("maxConnections")]
        public int MaxConnections { get; set; }

        /// <summary>
        /// The SRT passphrase is the shared secret between the source and the output.
        /// Only used when establishing a new connection, changing it will not disrupt existing ones.
        /// Length 10 to 79 characters.
        /// </summary>
        [JsonProperty("passphrase")]
        public object Passphrase { get; set; }

        /// <summary>
        /// Port currently in use by the Output.
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// Influences the decision as to whether a particular reported lost packet should be retransmitted at a certain time or not.
        /// <see cref="RetransmitAlgorithms"/>
        /// </summary>
        [JsonProperty("retransmitAlgorithm")]
        public int RetransmitAlgorithm { get; set; }

        /// <summary>
        /// Differentiated Services field. Entered as a base-10 decimal number, specifies all 8 bits including 6-bits DSCP then 2-bits ECN (Default = 0).
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
        /// <see cref="SrtOutputType"/>
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
    }
}