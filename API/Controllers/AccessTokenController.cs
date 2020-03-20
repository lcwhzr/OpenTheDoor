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
    public class AccessTokenController : ControllerBase
    {

        [HttpGet("create")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CreateAccessToken()
        {

            //Service method call
            //ex : 
            //Service.CreateAccessToken();



            var message = $"Hello from {nameof(CreateAccessToken)}";
            return new ObjectResult(message);
        }

        [HttpGet("revoke")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult RevokeAccessToken()
        {

            //Service method call
            //ex : 
            //Service.RevokeAccessToken();



            var message = $"Hello from {nameof(RevokeAccessToken)}";
            return new ObjectResult(message);
        }

        [HttpGet("check")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CheckAccessToken()
        {

            //Service method call
            //ex : 
            //Service.CheckAccessToken();



            var message = $"Hello from {nameof(CheckAccessToken)}";
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