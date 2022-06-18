using Microsoft.AspNetCore.Mvc;

namespace HBNext.NextgenApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningController : ControllerBase
    {
        // GET: api/<LearningController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LearningController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LearningController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LearningController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LearningController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
