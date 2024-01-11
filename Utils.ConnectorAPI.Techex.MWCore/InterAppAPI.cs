// Ignore Spelling: Api

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore
{
    using System;
    using System.Collections.Generic;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Resource type
    /// </summary>
    public enum InterAppResourceType
    {
        /// <summary>
        /// Stream
        /// </summary>
        Stream,
        /// <summary>
        /// Input
        /// </summary>
        Input,
        /// <summary>
        /// Output
        /// </summary>
        Output,
    }

    /// <summary>
    /// Actions possible to perform on MWCore.
    /// </summary>
    public enum InterAppAction
    {
        /// <summary>
        /// Create.
        /// </summary>
        Create,

        /// <summary>
        /// Delete
        /// </summary>
        Delete,

        /// <summary>
        /// Update
        /// </summary>
        Update
    }

    /// <summary>
    /// InterApp API that contains all the generic information.
    /// </summary>
    public static class InterAppApi
    {
        private static readonly List<Type> knownTypesValue = new List<Type> { typeof(RequestMessage), typeof(ResponseMessage) };

        /// <summary>
        ///  A list of all the possible Message classes, necessary for the default background serializer.
        /// </summary>
        public static List<Type> KnownTypes { get => knownTypesValue; }
    }

    /// <summary>
    /// Message sent to MWCore to create or delete a resource.
    /// </summary>
    public class RequestMessage : Message
    {
        /// <summary>
        /// Gets or sets the Action to perform (Create/Delete/Update).
        /// </summary>
        public InterAppAction Action { get; set; }

        /// <summary>
        /// Gets or sets the Type of resource (Stream/Input/Output).
        /// </summary>
        public InterAppResourceType Type { get; set; }

        /// <summary>
        /// Gets or sets Edge name for Stream or Edge ID for Input/Output.
        /// </summary>
        public string Edge { get; set; }
        
        /// <summary>
        /// Gets or sets the Stream, Input or Output primary key that needs to be updated. Only required when the Action is Update.
        /// </summary>
        public string ResourceToUpdate {get; set;}

        /// <summary>
        /// Gets or sets the request body to send for the MWCore. In case of Delete action is the resource display key.
        /// </summary>
        public string Body { get; set; }
    }

    /// <summary>
    /// Message received from MWCore on request status.
    /// </summary>
    public class ResponseMessage : Message
    {
        /// <summary>
        /// Gets or sets a value indicating whether the resource creation/deletion/update was successful.
        /// </summary>
        public bool SuccessfulCreation { get; set; }

        /// <summary>
        /// Gets or sets the resource display key.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the Type of resource (Stream/Input/Output).
        /// </summary>
        public InterAppResourceType Type { get; set; }

        /// <summary>
        /// Gets or sets the reason the action failed.
        /// </summary>
        public string Error { get; set; }
    }
}
