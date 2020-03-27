using System;
using System.Net.Mime;
using System.Text.Json;
using API.Features;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Text.Json.JsonElement;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        [HttpPost("create")]
        [Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Policy = Policies.all_access)]
        public IActionResult CreateService([FromBody] JsonElement body)
        {

            //JsonElement jv = new JsonElement(body);
            ArrayEnumerator ae = body.EnumerateArray();
            ae.MoveNext();
            var domainName = ae.Current.GetProperty("domainName").ToString();
            ae.MoveNext();
            var serviceScopeKey = ae.Current.GetProperty("serviceScopeKey").ToString();
            
            Console.WriteLine("domainName");
            Console.WriteLine(domainName);
            Console.WriteLine("serviceScopeKey");
            Console.WriteLine(serviceScopeKey);

            try
            {
                ServiceCreator sc = new ServiceCreator();
                sc.Create(domainName, serviceScopeKey);

            }
            catch (Exception)
            {

                throw;
            }

            //var message = $"Hello from {nameof(CreateService)} || {domainName} \\ {serviceScopeKey}";
            //return new ObjectResult(message);
            return new ObjectResult("");
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