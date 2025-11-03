// Ignore Spelling: Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Messages
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore;
	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages;
	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Models;

	/// <summary>
	/// Represents an InterApp response message returned from a <see cref="InterAppResourceType.StreamsBatch"/> request.
	/// </summary>
	public class StreamsBatchResponse : IMWCoreResponse
	{
		/// <summary>
		/// Gets or sets a value indicating whether the InterApp call was completely successful.
		/// If at least one operation in the batch failed, this will be false.
		/// </summary>
		public bool Successful { get; set; }

		/// <summary>
		/// Gets or sets the display key of the resource associated with this response.
		/// Should be null or empty for batch operations.
		/// </summary>
		public string Resource { get; set; }

		/// <summary>
		/// Gets or sets the resource DataMiner primary key.
		/// Should be null or empty for batch operations.
		/// </summary>
		public string ResourcePK { get; set; }

		/// <summary>
		/// Gets or sets the type of the resource (<see cref="InterAppResourceType.StreamsBatch"/>).
		/// </summary>
		public InterAppResourceType Type { get; set; }

		/// <summary>
		/// Gets or sets the error message when the action fails.
		/// </summary>
		public string Error { get; set; }

		/// <summary>
		/// Response Body from MWCore.
		/// </summary>
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the detailed result of the batch operation.
		/// </summary>
		public StreamsBatchResult BatchResult { get; set; }

		/// <inheritdoc/>
		public Message ToMessage()
		{
			return new GenericInterAppMessage<StreamsBatchResponse>(this);
		}

		/// <summary>
		/// Determines whether the InterApp call was successful.
		/// </summary>
		/// <returns><c>true</c> if successful; otherwise, <c>false</c>.</returns>
		public bool IsSuccessful()
		{
			return Successful;
		}

		/// <inheritdoc/>
		public void SetSuccessResult(bool result)
		{
			Successful = result;
		}
	}
}