using Microsoft.AspNetCore.Mvc;

namespace SympliDevelopment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        [HttpGet("keywords")]
        public Task<IActionResult> GetResult([FromQuery] string keywords)
        {
            // please implement this method to return the result correctly.
            // the method receives an input keywords and then return the ranking result

            // NOTE that you're free to change the return type from Task<IActionResult>
            // to anything else; you can also change the function parameters if needed.
            throw new NotImplementedException();
        }
    }
}
