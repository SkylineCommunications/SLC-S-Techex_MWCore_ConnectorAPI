// Ignore Spelling: Api Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
    using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
    using Skyline.DataMiner.Net;
    using Skyline.DataMiner.Net.Messages;
    using Utils.ConnectorAPI.Techex.MWCore.InterAppMessages;

    /// <summary>
    /// MWCoreInterAppCalls that contains all the generic information.
    /// </summary>
    public class MWCoreInterAppCalls : IMWCoreInterAppCalls
    {
        private TimeSpan defaultTimeout = TimeSpan.FromMinutes(2);

        /// <inheritdoc/>
        public IConnection SLNetConnection { get; set; }

        /// <inheritdoc/>
        public int AgentId { get; }

        /// <inheritdoc/>
        public int ElementId { get; }

        /// <summary>
		/// Initialize a new instance of the <see cref="MWCoreInterAppCalls"/> class.
		/// </summary>
		/// <param name="connection">The connection interface.</param>
		/// <param name="elementName">The name of the element in DataMiner.</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public MWCoreInterAppCalls(IConnection connection, string elementName)
        {
            if (String.IsNullOrEmpty(elementName))
            {
                throw new ArgumentException("Please provide a valid Element name.", nameof(elementName));
            }

            SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));

            ElementInfoEventMessage elementInfo;
            try
            {
                elementInfo = (ElementInfoEventMessage)SLNetConnection.HandleSingleResponseMessage(new GetElementByNameMessage
                {
                    ElementName = elementName,
                });
            }
            catch (Exception)
            {
                throw new ArgumentException($"The element does not exists with name '{elementName}'", nameof(elementName));
            }

            if (elementInfo.Protocol != Constants.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(elementName));
            }

            AgentId = elementInfo.DataMinerID;
            ElementId = elementInfo.ElementID;
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="MWCoreInterAppCalls"/> class.
        /// </summary>
        /// <param name="connection">The connection interface.</param>
        /// <param name="dmaId">The id of the DataMiner that is hosting the element.</param>
        /// <param name="elementId">The id of the element in DataMiner.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public MWCoreInterAppCalls(IConnection connection, int dmaId, int elementId)
        {
            if (dmaId == default)
            {
                throw new ArgumentException("Please provide a valid DMA ID.", nameof(dmaId));
            }

            if (elementId == default)
            {
                throw new ArgumentException("Please provide a valid Element ID.", nameof(elementId));
            }

            SLNetConnection = connection ?? throw new ArgumentNullException(nameof(connection));
            AgentId = dmaId;
            ElementId = elementId;

            ElementInfoEventMessage elementInfo;
            try
            {
                elementInfo = (ElementInfoEventMessage)SLNetConnection.HandleSingleResponseMessage(new GetElementByIDMessage
                {
                    DataMinerID = dmaId,
                    ElementID = elementId,
                });
            }
            catch
            {
                throw new ArgumentException($"The element does not exists with id '{dmaId}/{elementId}'", nameof(elementId));
            }

            if (elementInfo.Protocol != Constants.ProtocolName)
            {
                throw new ArgumentException($"The element is not running protocol '{Constants.ProtocolName}'", nameof(elementId));
            }
        }

        /// <inheritdoc/>
        public void SendMessageNoResponse(params IMWCoreRequest[] messages)
        {
            IInterAppCall myCommands = InterAppCallFactory.CreateNew();
            myCommands.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
            myCommands.Messages.AddMessage(messages.Select(InterAppApi.ToMessage).ToArray());
            myCommands.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, InterAppApi.KnownTypes);
        }

        /// <inheritdoc/>
        public IEnumerable<IMWCoreResponse> SendMessages(IMWCoreRequest[] messages, TimeSpan timeout = default)
        {
            var interAppCallTimeout = timeout;
            if (timeout == default)
            {
                interAppCallTimeout = defaultTimeout;
            }

            IInterAppCall myCommands = InterAppCallFactory.CreateNew();
            myCommands.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
            myCommands.Messages.AddMessage(messages.Select(InterAppApi.ToMessage).ToArray());
            var internalResults = myCommands.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, InterAppApi.KnownTypes);
            return internalResults.Select(result => InterAppApi.FromMessage(result));
        }

        /// <inheritdoc/>
        public IMWCoreResponse SendSingleResponseMessage(IMWCoreRequest message, TimeSpan timeout = default)
        {
            var interAppCallTimeout = timeout;
            if (timeout == default)
            {
                interAppCallTimeout = defaultTimeout;
            }

            IInterAppCall myCommand = InterAppCallFactory.CreateNew();
            myCommand.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
            myCommand.Messages.AddMessage(InterAppApi.ToMessage(message));
            var internalResult = myCommand.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, InterAppApi.KnownTypes).First();
            return InterAppApi.FromMessage(internalResult);
        }

        /// <inheritdoc/>
        public T SendSingleResponseMessage<T>(IMWCoreRequest message, TimeSpan timeout = default)
            where T : IMWCoreResponse
        {
            var result = SendSingleResponseMessage(message, timeout);
            return (T)result;
        }
    }
}