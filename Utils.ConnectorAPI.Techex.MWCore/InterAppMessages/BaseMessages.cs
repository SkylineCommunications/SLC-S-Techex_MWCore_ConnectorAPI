// Ignore Spelling: Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore;

    /// <summary>
    /// Represents an InterApp Message that a Techex MWCore element can receive.
    /// </summary>
    public interface IMWCoreInterAppMessage
    {
    }

    /// <summary>
    /// Represents a generic inter-application message that contains data of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the data contained in the message, which must implement <see cref="IMWCoreInterAppMessage"/>.</typeparam>
    public class GenericInterAppMessage<T> : Message
            where T : IMWCoreInterAppMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericInterAppMessage{T}"/> class with the specified data.
        /// </summary>
        /// <param name="data">The data contained in the message.</param>
        public GenericInterAppMessage(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Gets the data contained in the message.
        /// </summary>
        public T Data { get; }
    }

    /// <summary>
    /// Base class that hold default properties that every request has.
    /// </summary>
    public interface IMWCoreRequest : IMWCoreInterAppMessage
    {
        /// <summary>
        /// Gets or sets the Action to perform (Create/Delete/Update).
        /// </summary>
        InterAppAction Action { get; set; }

        /// <summary>
        /// Gets or sets the Type of resource (Stream/Input/Output).
        /// </summary>
        InterAppResourceType Type { get; set; }

        /// <summary>
        /// Gets or sets Edge name. Only one of the EdgeName or EdgeID properties is required to be filled in.
        /// Not required when the Action is Update.
        /// </summary>
        string EdgeName { get; set; }

        /// <summary>
        /// Gets or sets Edge ID. Only one of the EdgeName or EdgeID properties is required to be filled in.
        /// Not required when the Action is Update.
        /// </summary>
        string EdgeID { get; set; }

        /// <summary>
        /// Gets or sets the Stream, Input or Output DataMiner primary key that needs to be updated.
        /// Only required when the Action is Update.
        /// </summary>
        string ResourceToUpdate { get; set; }

        /// <summary>
        /// Gets or sets the request body to send for the MWCore. In case of Delete action is the resource display key.
        /// </summary>
        string Body { get; set; }
    }

    /// <summary>
    /// Base class that hold default properties that every response has.
    /// </summary>
    public interface IMWCoreResponse : IMWCoreInterAppMessage
    {
        /// <summary>
        /// Gets or sets the resource display key.
        /// </summary>
        string Resource { get; set; }

        /// <summary>
        /// Gets or sets the Type of resource (Stream/Input/Output).
        /// </summary>
        InterAppResourceType Type { get; set; }

        /// <summary>
        /// Gets or sets the reason the action failed.
        /// </summary>
        string Error { get; set; }

        /// <summary>
		/// Indicates if the InterApp Call was successful or not
		/// </summary>
        bool IsSuccessful();

        /// <summary>
		/// Sets the result from the request made.
		/// </summary>
        void SetSuccessResult(bool result);

        /// <summary>
        /// Generates the <see cref="Message"/> to be sent back via InterApp.
        /// </summary>
        /// <returns><see cref="Message"/> with the response from the request.</returns>
        Message ToMessage();
    }
}