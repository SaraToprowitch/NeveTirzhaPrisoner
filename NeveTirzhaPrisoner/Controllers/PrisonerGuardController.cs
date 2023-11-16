using Microsoft.AspNetCore.Mvc;
using NeveTirzahPrison;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeveTirzahPrison.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrisonerGuardController : ControllerBase
    {
        public PrisonerGuardController(DataContext dataContext)
        {

        }
        // GET: api/<PrisonerGuardController>
        [HttpGet]
        public IEnumerable<PrisonGuard> Get()
        {
            return DataContext.prisonGuards;
        }

        // GET api/<PrisonerGuardController>/5
        [HttpGet("{id}")]
        public ActionResult<PrisonGuard> Get(int id)
        {
            var x = DataContext.prisonGuards.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                return x;
            }
        }

        // POST api/<PrisonerGuardController>
        [HttpPost]
        public void Post([FromBody] PrisonGuard value)
        {
            DataContext.prisonGuards.Add(new PrisonGuard { Id = value.Id, Name = value.Name, Role = value.Role, ShiftTime = value.ShiftTime, HourlySalary = value.HourlySalary });
        }

        // PUT api/<PrisonerGuardController>/5
        [HttpPut("{id}")]
        public ActionResult<PrisonGuard> Put(int id, [FromBody] PrisonGuard value)
        {
            var x = DataContext.prisonGuards.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                x.Id = value.Id;
                x.Name = value.Name;
                x.Role = value.Role;
                x.ShiftTime = value.ShiftTime;
                x.HourlySalary = value.HourlySalary;
                return x;
            }
        }
        // PUT api/<PrisonerGuardController>/5
        [HttpPut("/api/<PrisonerGuard/updateSalary")]
        public ActionResult<PrisonGuard> Put()
        {
            var x = DataContext.prisonGuards.Find(r => r.ShiftTime == Shift.night);
            if (x == null)
                return NotFound();
            else
            {
                x.HourlySalary = x.HourlySalary + 50f;
                return x;
            }
        }

        // DELETE api/<PrisonerGuardController>/5
        [HttpDelete("{id}")]
        public ActionResult<PrisonGuard> Delete(int id)
        {
            var x = DataContext.prisonGuards.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                DataContext.prisonGuards.Remove(x);
                return NoContent();
            }
        }
    }
}
