// Ignore Spelling: Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Models
{
	/// <summary>
	/// Represents the result of creating a source or output for a stream.
	/// </summary>
	public class SourceOutputCreationResult
	{
		/// <summary>
		/// Gets or sets the primary key of the stream associated with the source or output.
		/// </summary>
		public string StreamPrimaryKey { get; set; }

		/// <summary>
		/// Gets or sets the display key (human-readable identifier) of the created source or output.
		/// </summary>
		public string DisplayKey { get; set; }

		/// <summary>
		/// Gets or sets the unique primary key of the created source or output.
		/// </summary>
		public string PrimaryKey { get; set; }

		/// <summary>
		/// Gets or sets the error message if the creation failed.
		/// </summary>
		public string Error { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the creation was successful.
		/// </summary>
		public bool Successful { get; set; }
	}
}