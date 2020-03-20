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

        [HttpGet("create")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CreateService()
        {

            //Service method call
            //ex : 
            //Service.CreateService();



            var message = $"Hello from {nameof(CreateService)}";
            return new ObjectResult(message);
        }

        [HttpGet("delete")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult DeleteService()
        {

            //Service method call
            //ex : 
            //Service.DeleteService();



            var message = $"Hello from {nameof(DeleteService)}";
            return new ObjectResult(message);
        }

        [HttpGet("update")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult UpdateService()
        {

            //Service method call
            //ex : 
            //Service.UpdateService();



            var message = $"Hello from {nameof(UpdateService)}";
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