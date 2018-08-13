using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    // ApiController class annotation provides several REST conventions when used with ControllerBase. New in dotnet2.1
    /** Automatic HTTP 400 responses
        Validation errors automatically trigger an HTTP 400 response. The following code becomes unnecessary in your actions:

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
    */


    [ApiController]
    // WebApi controllers inherit from ControllerBase class, which removes ASP.NET Views dependencies for less overhead and better performance
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        // ActionResult<T> wraps an expected type in an ActionResult (Automatic REST status codes: OK-200, NotFound-404, etc)
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        /** ApiController provides Binding source parameter inference
            A binding source attribute defines the location at which an action parameter's value is found. The following binding source attributes exist:

            Attribute	Binding source
            [FromBody]	Request body
            [FromForm]	Form data in the request body
            [FromHeader]	Request header
            [FromQuery]	Request query string parameter
            [FromRoute]	Route data from the current request
            [FromServices]	The request service injected as an action parameter

            If the Binding Source attribute is not specified it will be inferred based on the provided payload
        **/
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
