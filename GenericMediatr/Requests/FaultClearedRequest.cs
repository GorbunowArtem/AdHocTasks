using CFX.ResourcePerformance;
using GenericMediatr.Models;

namespace GenericMediatr.Requests
{
	public class FaultClearedRequest: IParseCfxMessageRequest<FaultCleared>
	{
		public FaultClearedRequest(CfxEctmEvent<FaultCleared> message)
		{
			Message = message;
		}

		public CfxEctmEvent<FaultCleared> Message { get; }
	}
}