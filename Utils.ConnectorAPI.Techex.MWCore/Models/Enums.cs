// Ignore Spelling: Techex Utils

namespace Utils.ConnectorAPI.Techex.MWCore.Models
{
    /// <summary>
    /// Available SRT Output types
    /// </summary>
    public enum SRTOutputType
    {
        /// <summary>
        /// SRT Output is listener type
        /// </summary>
        Listener = 0,

        /// <summary>
        /// SRT Output is push type
        /// </summary>
        Push = 1,
    }

    /// <summary>
    /// Available SRT Source types
    /// </summary>
    public enum SRTSourceType
    {
        /// <summary>
        /// SRT Source is listener type
        /// </summary>
        Listener = 1,

        /// <summary>
        /// SRT Source is push type
        /// </summary>
        Pull = 0,
    }

    /// <summary>
    /// Available transmission types.
    /// </summary>
    public enum TransmissionTypes
    {
        /// <summary>
        /// Unicast
        /// </summary>
        Unicast = 0,

        /// <summary>
        /// Multicast
        /// </summary>
        Multicast = 1,
    }

    /// <summary>
    /// Predefine chunk sizes.
    /// </summary>
    public enum ChunkSizes
    {
        /// <summary>
        /// UDP chunk size
        /// </summary>
        UDP = 1316,

        /// <summary>
        /// RTP chunk size
        /// </summary>
        RTP = 1328,
    }

    /// <summary>
    /// Retransmit Algorithm possible values.
    /// </summary>
    public enum RetransmitAlgorithms
    {
        /// <summary>
        /// Retransmit on every loss report
        /// </summary>
        OnEveryLoss = 0,

        /// <summary>
        /// Retransmit not more often than once per RTT
        /// </summary>
        OncePerRtt = 1,
    }

    /// <summary>
    /// Encryption possible values.
    /// </summary>
    public enum TransportEncryptions
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// AES-128
        /// </summary>
        AES128 = 16,

        /// <summary>
        /// AES-192
        /// </summary>
        AES192 = 24,

        /// <summary>
        /// AES-256
        /// </summary>
        AES256 = 32,
    }

    /// <summary>
    /// Output log level possible values.
    /// </summary>
    public enum OutputLogLevels
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Critical
        /// </summary>
        Critical = 2,

        /// <summary>
        /// Error
        /// </summary>
        Error = 3,

        /// <summary>
        /// Warning
        /// </summary>
        Warning = 4,

        /// <summary>
        /// Notice
        /// </summary>
        Notice = 5,

        /// <summary>
        /// Debug
        /// </summary>
        Debug = 7,
    }
}