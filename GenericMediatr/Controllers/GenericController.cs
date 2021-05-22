using CFX;
using CFX.Production;
using CFX.Production.TestAndInspection;
using CFX.ResourcePerformance;
using Microsoft.AspNetCore.Mvc;

namespace GenericMediatr.Controllers
{
	[ApiController]
	public class GenericController: ControllerBase
	{
		private readonly CFXMessage[] _messages = {
			new FaultCleared(),
			new FaultOccurred(),
			new UnitsInspected(),
			new RecipeActivated()
		};

	}
}