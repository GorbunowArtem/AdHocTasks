using CFX;
using CFX.ResourcePerformance;
using GenericMediatr.Models;

namespace GenericMediatr.Requests
{
	public class ParseCfxMessageRequest<T>: IParseCfxMessageRequest<T> where T : CFXMessage
	{
		public ParseCfxMessageRequest(CfxEctmEvent<T> message)
		{
			Message = message;
		}

		public CfxEctmEvent<T> Message { get; }
	}
}