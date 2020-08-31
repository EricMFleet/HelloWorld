using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageController : ControllerBase
	{
		public IActionResult Message()
		{
			return Content("Hello World");
		}
	}
}