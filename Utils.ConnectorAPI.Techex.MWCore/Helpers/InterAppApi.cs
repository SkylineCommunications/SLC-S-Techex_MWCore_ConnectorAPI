// Ignore Spelling: Api Utils Techex App

namespace Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore
{
	using System;
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages;
	using Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore.InterAppMessages.Messages;

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
		Update,

		/// <summary>
		/// Clear Stats
		/// </summary>
		ClearStats
	}

	/// <summary>
	/// InterApp API that contains all the generic information.
	/// </summary>
	public static class InterAppApi
	{
		private static readonly List<Type> knownTypesValue = new List<Type>
		{
			typeof(RequestMessage),
			typeof(ResponseMessage),
			typeof(GenericInterAppMessage<MWCoreRequest>),
			typeof(GenericInterAppMessage<MWCoreResponse>),
		};

		/// <summary>
		///  A list of all the possible Message classes, necessary for the default background serializer.
		/// </summary>
		public static List<Type> KnownTypes { get => knownTypesValue; }

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