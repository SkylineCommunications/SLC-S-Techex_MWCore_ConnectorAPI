// Ignore Spelling: Utils Techex App

namespace Utils.ConnectorAPI.Techex.MWCore
{
    /// <summary>
	/// Contains constant values used in the ConnectorAPI.
	/// </summary>
	public static class Constants
    {
        /// <summary>
        /// The protocol name of the Techex MWCore.
        /// </summary>
        public const string ProtocolName = "Techex MWCore";

        /// <summary>
        /// The ID of the parameter that will receive the InterApp Messages
        /// </summary>
        public const int InterAppReceiverPID = 9000000;

        /// <summary>
        /// The ID of the parameter that will hold the responses for the InterApp Messages
        /// </summary>
        public const int InterAppResponsePID = 9000001;
    }
}