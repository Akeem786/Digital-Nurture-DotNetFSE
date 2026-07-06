using Microsoft.AspNetCore.Mvc;

namespace WebApiHandson8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok("POST Success");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok("PUT Success");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("DELETE Success");
        }
    }
}