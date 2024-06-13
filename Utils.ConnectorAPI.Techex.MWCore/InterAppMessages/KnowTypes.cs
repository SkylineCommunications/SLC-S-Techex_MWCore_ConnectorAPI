// Ignore Spelling: Utils Techex App

namespace Utils.ConnectorAPI.Techex.MWCore.InterAppMessages
{
    using System;
    using System.Collections.Generic;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Messages;

    /// <summary>
    /// Static class holding the types of the InterApp Messages.
    /// </summary>
    public static class Types
    {
        /// <summary>
        /// Gets a list of all the supported InterApp Message Types.
        /// </summary>
        public static List<Type> KnownTypes { get; } = new List<Type>
        {
			// Example Messages
			typeof(GenericInterAppMessage<MWCoreRequest>),
            typeof(GenericInterAppMessage<MWCoreResponse>),
        };

        /// <summary>
        /// Converts an <see cref="IMWCoreRequest"/> message to a <see cref="Message"/> object.
        /// </summary>
        /// <param name="message">The <see cref="IMWCoreRequest"/> message to be converted.</param>
        /// <returns>
        /// A <see cref="Message"/> object that represents the specified <see cref="IMWCoreRequest"/> message.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when the message type is unknown.</exception>
        internal static Message ToMessage(IMWCoreRequest message)
        {
            switch (message)
            {
                case MWCoreRequest requestData:
                    return new GenericInterAppMessage<MWCoreRequest>(requestData);

                default:
                    throw new InvalidOperationException("Unknown message type");
            }
        }

        /// <summary>
        /// Converts a <see cref="Message"/> object to an <see cref="IMWCoreResponse"/>.
        /// </summary>
        /// <param name="message">The <see cref="Message"/> to be converted.</param>
        /// <returns>
        /// An <see cref="IMWCoreResponse"/> object that represents the data from the specified <see cref="Message"/>.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when the message type is unknown.</exception>
        internal static IMWCoreResponse FromMessage(Message message)
        {
            switch (message)
            {
                case GenericInterAppMessage<MWCoreResponse> requestResult:
                    return requestResult.Data;

                default:
                    throw new InvalidOperationException("Unknown message type");
            }
        }
    }
}