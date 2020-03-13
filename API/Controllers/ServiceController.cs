using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        [HttpGet("anyone")]
        public IActionResult Anyone()
        {
            var message = $"Hello from {nameof(Anyone)}";
            return new ObjectResult(message);
        }

        [HttpGet("only-authenticated")]
        [Authorize]
        public IActionResult OnlyAuthenticated()
        {
            var message = $"Hello from {nameof(OnlyAuthenticated)}";
            return new ObjectResult(message);
        }

        //[HttpGet("only-employees")]
        //public IActionResult OnlyEmployees()
        //{
        //    var message = $"Hello from {nameof(OnlyEmployees)}";
        //    return new ObjectResult(message);
        //}

        [HttpGet("only-services")]
        public IActionResult OnlyServices()
        {
            var message = $"Hello from {nameof(OnlyServices)}";
            return new ObjectResult(message);
        }

        //[HttpGet("only-third-parties")]
        //public IActionResult OnlyThirdParties()
        //{
        //    var message = $"Hello from {nameof(OnlyThirdParties)}";
        //    return new ObjectResult(message);
        //}
    }


    
}