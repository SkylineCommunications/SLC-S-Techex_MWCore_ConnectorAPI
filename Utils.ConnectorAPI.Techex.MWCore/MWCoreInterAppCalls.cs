// Ignore Spelling: Api Utils Techex App

namespace Utils.ConnectorAPI.Techex.MWCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
    using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
    using Skyline.DataMiner.Net;
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

        /// <inheritdoc/>
        public void SendMessageNoResponse(params IMWCoreRequest[] messages)
        {
            IInterAppCall myCommands = InterAppCallFactory.CreateNew();
            myCommands.ReturnAddress = new ReturnAddress(AgentId, ElementId, Constants.InterAppResponsePID);
            myCommands.Messages.AddMessage(messages.Select(Types.ToMessage).ToArray());
            myCommands.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, Types.KnownTypes);
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
            myCommands.Messages.AddMessage(messages.Select(Types.ToMessage).ToArray());
            var internalResults = myCommands.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes);
            return internalResults.Select(result => Types.FromMessage(result));
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
            myCommand.Messages.AddMessage(Types.ToMessage(message));
            var internalResult = myCommand.Send(SLNetConnection, AgentId, ElementId, Constants.InterAppReceiverPID, interAppCallTimeout, Types.KnownTypes).First();
            return Types.FromMessage(internalResult);
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