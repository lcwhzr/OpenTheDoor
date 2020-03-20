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
    public class AccesTokenController : ControllerBase
    {

        [HttpGet("create")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CreateAccesToken()
        {

            //Service method call
            //ex : 
            //Service.CreateAccesToken();



            var message = $"Hello from {nameof(CreateAccesToken)}";
            return new ObjectResult(message);
        }

        [HttpGet("revoke")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult RevokeAccesToken()
        {

            //Service method call
            //ex : 
            //Service.RevokeAccesToken();



            var message = $"Hello from {nameof(RevokeAccesToken)}";
            return new ObjectResult(message);
        }

        [HttpGet("check")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CheckAccesToken()
        {

            //Service method call
            //ex : 
            //Service.CheckAccesToken();



            var message = $"Hello from {nameof(CheckAccesToken)}";
            return new ObjectResult(message);
        }








        //    [HttpGet("method2")]
        //    [Authorize(Policy = Policies.all_access)]
        //    public IActionResult Create2Access()
        //    {
        //        var message = $"Hello from {nameof(Create2Access)}";
        //        return new ObjectResult(message);
        //    }

        //    //[HttpGet("only-third-parties")]
        //    //public IActionResult OnlyThirdParties()
        //    //{
        //    //    var message = $"Hello from {nameof(OnlyThirdParties)}";
        //    //    return new ObjectResult(message);
        //    //}
        //}



    }
}