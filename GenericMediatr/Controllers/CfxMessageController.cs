using System.Threading.Tasks;
using CFX.ResourcePerformance;
using GenericMediatr.Models;
using GenericMediatr.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GenericMediatr.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CfxMessageController : ControllerBase
	{
		private readonly ISender _sender;

		public CfxMessageController(ISender sender)
		{
			_sender = sender;
		}

		[HttpPost]
		[Route("FaultCleared")]
		public async Task<IActionResult> Parse([FromBody] CfxEctmEvent<FaultCleared> message)
		{
			await _sender.Send(new ParseCfxMessageRequest<FaultCleared>(message));

			return Ok();
		}
		
		[HttpPost]
		[Route("FaultOccurred")]
		public async Task<IActionResult> Parse([FromBody] CfxEctmEvent<FaultOccurred> message)
		{
			await _sender.Send(new ParseCfxMessageRequest<FaultOccurred>(message));

			return Ok();
		}
	}
}