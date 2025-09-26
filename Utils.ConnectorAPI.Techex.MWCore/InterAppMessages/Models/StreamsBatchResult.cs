// Ignore Spelling: Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Models
{
	using System.Collections.Generic;

	/// <summary>
	/// Represents the result of a batch operation that creates streams, sources, and outputs.
	/// </summary>
	public class StreamsBatchResult
	{
		/// <summary>
		/// Gets or sets the collection of results for created streams.
		/// </summary>
		public List<StreamCreationResult> Streams { get; set; } = new List<StreamCreationResult>();

		/// <summary>
		/// Gets or sets the collection of results for created sources.
		/// </summary>
		public List<SourceOutputCreationResult> Sources { get; set; } = new List<SourceOutputCreationResult>();

		/// <summary>
		/// Gets or sets the collection of results for created outputs.
		/// </summary>
		public List<SourceOutputCreationResult> Outputs { get; set; } = new List<SourceOutputCreationResult>();
	}
}