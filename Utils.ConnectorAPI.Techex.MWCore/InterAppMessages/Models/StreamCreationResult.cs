// Ignore Spelling: Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Models
{
	/// <summary>
	/// Represents the result of a stream creation operation.
	/// </summary>
	public class StreamCreationResult
	{
		/// <summary>
		/// Gets or sets the display key (human-readable identifier) of the created stream.
		/// </summary>
		public string DisplayKey { get; set; }

		/// <summary>
		/// Gets or sets the unique primary key of the created stream.
		/// </summary>
		public string PrimaryKey { get; set; }

		/// <summary>
		/// Gets or sets the error message if the creation failed.
		/// </summary>
		public string Error { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the stream creation was successful.
		/// </summary>
		public bool Successful { get; set; }
	}
}