using HBNext.Nextgen.BusinessManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBNext.Nextgen.BusinessManager.Managers
{
    public class IncidentManager
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "ScorchingHeat"
        };

        // Call Model and return model.
        // Use Data class to make insert and update to SQL db directly.
        public IEnumerable<Incident> GetIncidents()
        {
            return Enumerable.Range(1, 5).Select(index => new Incident
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
           .ToArray();
        }

    }
}
