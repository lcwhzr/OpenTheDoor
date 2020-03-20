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
    public class ScopeController : ControllerBase
    {

        [HttpGet("create")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CreateScope()
        {

            //Service method call
            //ex : 
            //Service.CreateScope();



            var message = $"Hello from {nameof(CreateScope)}";
            return new ObjectResult(message);
        }

        [HttpGet("delete")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult DeleteScope()
        {

            //Service method call
            //ex : 
            //Service.DeleteScope();



            var message = $"Hello from {nameof(DeleteScope)}";
            return new ObjectResult(message);
        }

        [HttpGet("update")]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult UpdateScope()
        {

            //Service method call
            //ex : 
            //Service.UpdateScope();



            var message = $"Hello from {nameof(UpdateScope)}";
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