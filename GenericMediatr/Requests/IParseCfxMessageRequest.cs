using CFX;
using GenericMediatr.Models;
using MediatR;

namespace GenericMediatr.Requests
{
	public interface IParseCfxMessageRequest<TMessage>: IRequest where TMessage : CFXMessage
	{
		CfxEctmEvent<TMessage> Message { get; }
	}
}