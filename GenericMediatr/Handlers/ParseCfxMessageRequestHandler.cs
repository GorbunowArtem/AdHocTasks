using System.Threading;
using System.Threading.Tasks;
using CFX;
using GenericMediatr.Parsers;
using GenericMediatr.Requests;
using MediatR;

namespace GenericMediatr.Handlers
{
	public class ParseCfxMessageRequestHandler<TEntity, TCommand> : AsyncRequestHandler<TCommand>
		where TEntity : CFXMessage
		where TCommand : IParseCfxMessageRequest<TEntity>
	{
		private readonly IMessageParser<TEntity> _parser;

		public ParseCfxMessageRequestHandler(IMessageParser<TEntity> parser)
		{
			_parser = parser;
		}

		protected override Task Handle(TCommand request, CancellationToken cancellationToken)
		{
			_parser.Parse(request.Message.Transaction.Content.Body);
			
				return Task.CompletedTask;;
		}
	}
}