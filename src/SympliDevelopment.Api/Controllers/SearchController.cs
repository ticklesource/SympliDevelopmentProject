using Microsoft.AspNetCore.Mvc;

namespace SympliDevelopment.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class SearchController : ControllerBase
  {
   
    [HttpGet("keywords")]
    public async Task<IActionResult> GetResult([FromQuery] string keywords)
    {
        // please implement this method to return the result correctly.
        // the method receives an input keywords and then return the ranking result
        
    }
    
  }
}