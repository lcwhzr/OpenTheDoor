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
    public class RefreshTokenController : ControllerBase
    {

        [HttpGet("create")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CreateRefreshToken()
        {

            //Service method call
            //ex : 
            //Service.CreateRefreshToken();



            var message = $"Hello from {nameof(CreateRefreshToken)}";
            return new ObjectResult(message);
        }

        [HttpGet("revoke")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult RevokeRefreshToken()
        {

            //Service method call
            //ex : 
            //Service.RevokeRefreshToken();



            var message = $"Hello from {nameof(RevokeRefreshToken)}";
            return new ObjectResult(message);
        }

        [HttpGet("check")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CheckRefreshToken()
        {

            //Service method call
            //ex : 
            //Service.CheckRefreshToken();



            var message = $"Hello from {nameof(CheckRefreshToken)}";
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