// Ignore Spelling: Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore
{
	using System;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages;

	/// <summary>
	/// Message sent to MWCore to create or delete a resource.
	/// </summary>
	[Obsolete("This object should no longer be used to prevent InterApp DLL related issues. Use the MWCoreInterAppCalls class to send an InterApp message.", false)]
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
		/// Not required when the Action is Update.
		/// </summary>
		public string Edge { get; set; }

		/// <summary>
		/// Gets or sets the Stream, Input or Output DataMiner primary key that needs to be updated.
		/// Only required when the Action is Update.
		/// </summary>
		public string ResourceToUpdate { get; set; }

		/// <summary>
		/// Gets or sets the request body to send for the MWCore. In case of Delete action is the resource display key.
		/// </summary>
		public string Body { get; set; }
	}

	/// <summary>
	/// Message received from MWCore on request status.
	/// </summary>
	[Obsolete("This object should no longer be used to prevent InterApp DLL related issues. Use the MWCoreInterAppCalls class to send an InterApp message.", false)]
	public class ResponseMessage : Message, IMWCoreResponse
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
		/// Response Body from MWCore.
		/// </summary>
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the reason the action failed.
		/// </summary>
		public string Error { get; set; }

		/// <inheritdoc/>
		public string ResourcePK { get; set; }

		/// <inheritdoc/>
		public Message ToMessage()
		{
			return this;
		}

		/// <inheritdoc/>
		public bool IsSuccessful()
		{
			return SuccessfulCreation;
		}

		/// <inheritdoc/>
		public void SetSuccessResult(bool result)
		{
			SuccessfulCreation = result;
		}
	}
}