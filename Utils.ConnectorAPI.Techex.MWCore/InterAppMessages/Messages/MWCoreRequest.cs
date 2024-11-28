// Ignore Spelling: Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Messages
{
	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore;

	/// <summary>
	/// InterApp Message that will execute the request made to MWCore.
	/// </summary>
	public class MWCoreRequest : IMWCoreRequest
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
		/// Gets or sets Edge name. Only one of the EdgeName or EdgeID properties is required to be filled in.
		/// Not required when the Action is Update.
		/// </summary>
		public string EdgeName { get; set; }

		/// <summary>
		/// Gets or sets Edge ID. Only one of the EdgeName or EdgeID properties is required to be filled in.
		/// Not required when the Action is Update.
		/// </summary>
		public string EdgeID { get; set; }

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
}