using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Features;
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

        //[HttpGet("only-all-access")]
        //[Authorize(Policy = Policies.all_access)]
        //public IActionResult AllAccess()
        //{
        //    var message = $"Hello from {nameof(AllAccess)}";
        //    return new ObjectResult(message);
        //}

        //[HttpGet("only-auth-access")]
        //[Authorize(Policy = Policies.authentication_access)]
        //public IActionResult AuthAccess()
        //{
        //    var message = $"Hello from {nameof(AuthAccess)}";
        //    return new ObjectResult(message);
        //}

        [HttpGet("method")]
        [Authorize(Policy = Policies.authentication_access)]
        public IActionResult CreateAccess()
        {
            var message = $"Hello from {nameof(CreateAccess)}";
            return new ObjectResult(message);
        }



        [HttpGet("method2")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult Create2Access()
        {
            var message = $"Hello from {nameof(Create2Access)}";
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