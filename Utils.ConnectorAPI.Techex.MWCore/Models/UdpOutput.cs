// Ignore Spelling: Utils Techex Tos

using Newtonsoft.Json;

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.Models
{
    /// <summary>
    /// Model to represent the UDP Output
    /// </summary>
    public class UdpOutput : BasicOutput
    {
        /// <summary>
        /// UDP Output configuration.
        /// </summary>
        [JsonProperty("options")]
        public UdpOutputOptions Options { get; set; }
    }

    /// <summary>
    /// Model to represent the UDP Output Options
    /// </summary>
    public class UdpOutputOptions
    {
        /// <summary>
        /// IP Address of the Output.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

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
        /// Limits the number of SRT connections for this Output (Unlimited = 0).
        /// Only show when output type is Listener.
        /// </summary>
        [JsonProperty("maxConnections")]
        public int MaxConnections { get; set; }

        /// <summary>
        /// The IP of the interface to output the stream on.
        /// </summary>
        [JsonProperty("networkInterface")]
        public string NetworkInterface { get; set; }

        /// <summary>
        /// Port currently in use by the Output.
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// Differentiated Services field. Entered as a base-10 decimal number, specifies all 8 bits including 6-bits DSCP then 2-bits ECN (Default = 0).
        /// </summary>
        [JsonProperty("tosField")]
        public object TosField { get; set; }

        /// <summary>
        /// IPv4 Time To Live or IPv6 unicast hops.
        /// </summary>
        [JsonProperty("ttl")]
        public int Ttl { get; set; }
    }
}