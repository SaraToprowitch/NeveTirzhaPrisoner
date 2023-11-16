using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeveTirzahPrison.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrisonerController : ControllerBase
    {
        public PrisonerController(DataContext dataContext)
        {

        }

        // GET: api/<PrisonerController>
        [HttpGet]
        public IEnumerable<Prisoner> Get()
        {
            return DataContext.prisoners;
        }

        // GET api/<PrisonerController>/5
        [HttpGet("{id}")]
        public ActionResult<Prisoner> Get(int id)
        {
            var x = DataContext.prisoners.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                return x;
            }
        }

        // POST api/<PrisonerController>
        [HttpPost]
        public void Post([FromBody] Prisoner value)
        {
            DataContext.prisoners.Add(new Prisoner { Id = value.Id, Name = value.Name, DateBirth = value.DateBirth, YearsInPrison = value.YearsInPrison, Religion = value.Religion });
        }

        // PUT api/<PrisonerController>/5
        [HttpPut("{id}")]
        public ActionResult<Prisoner> Put(int id, [FromBody] Prisoner value)
        {
            var x = DataContext.prisoners.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                x.Id = value.Id;
                x.Name = value.Name;
                x.DateBirth = value.DateBirth;
                x.YearsInPrison = value.YearsInPrison;
                x.Religion = value.Religion;
                return x;
            }
        }

        // PUT api/<PrisonerController>/5/updateYears
        [HttpPut("{id}/updateYears")]
        public ActionResult<Prisoner> UpdateYearsInPrison(int id, int years)
        {
            var x = DataContext.prisoners.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                if ((x.YearsInPrison - years) > 0)
                    x.YearsInPrison = x.YearsInPrison - years;
                else Delete(x.Id);
                return NoContent();
            }
        }

        // DELETE api/<PrisonerController>/5
        [HttpDelete("{id}")]
        public ActionResult<Prisoner> Delete(int id)
        {
            var x = DataContext.prisoners.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                DataContext.prisoners.Remove(x);
                return NoContent();
            }
        }
    }
}

