using HBNext.Nextgen.BusinessManager.Managers;
using HBNext.Nextgen.BusinessManager.Model;
using Microsoft.AspNetCore.Mvc;

namespace HBNext.NextgenApp.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {

        private readonly ILogger<IncidentController> _logger;

        public IncidentController(ILogger<IncidentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetIncidents")]
        public IEnumerable<Incident> Get()
        {
            //Add business manager  object and call business function.
            IncidentManager incidentManager = new IncidentManager();
            return incidentManager.GetIncidents();
        }       

        // GET api/<IncidentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IncidentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IncidentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IncidentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
