// Ignore Spelling: Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Messages
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore;

    /// <summary>
	/// InterApp Message that represent the response from the request made.
	/// </summary>
    public class MWCoreResponse : IMWCoreResponse
    {
        /// <summary>
        /// Indicates if the InterApp Call was successful or not
        /// </summary>
        public bool Successful { get; set; }

        /// <summary>
        /// Gets or sets the resource display key.
        /// </summary>
        public string Resource { get; set; }

        /// <inheritdoc/>
        public string ResourcePK { get; set; }

        /// <summary>
        /// Gets or sets the Type of resource (Stream/Input/Output).
        /// </summary>
        public InterAppResourceType Type { get; set; }

        /// <summary>
        /// Gets or sets the reason the action failed.
        /// </summary>
        public string Error { get; set; }

        /// <inheritdoc/>
        public Message ToMessage()
        {
           return new GenericInterAppMessage<MWCoreResponse>(this);
        }

        /// <summary>
        /// Indicates if the InterApp Call was successful or not.
        /// </summary>
        public bool IsSuccessful()
        { return Successful; }

        /// <inheritdoc/>
        public void SetSuccessResult(bool result)
        {
            Successful = result;
        }
    }
}