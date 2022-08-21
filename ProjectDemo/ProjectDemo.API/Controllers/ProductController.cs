using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("Check")]
        public IActionResult CheckResponse()
        {
            //Write your code here
            Response res = new Response()
            {
                ResponseId = Guid.NewGuid().ToString(),
                StatusCode = "200",
                Message =  "Service Executed Successfully"
            };

            return Ok(res);
        }
    }

    public class Response
    {
        public string? ResponseId { get; set; }
        public string? StatusCode { get; set; }            
        public string?  Message { get; set; }
    }
}
