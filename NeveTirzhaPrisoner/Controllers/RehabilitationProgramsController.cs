using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeveTirzahPrison.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RehabilitationProgramsController : ControllerBase
    {
        public RehabilitationProgramsController(DataContext dataContext)
        {

        }
        // GET: api/<RehabilitationProgramsController>
        [HttpGet]
        public IEnumerable<RehabilitationPrograms> GetByDay(Day day)
        {
            return DataContext.rehabilitationPrograms.Where(r => r.DayOfWeek == day);
        }

        // GET api/<RehabilitationProgramsController>/5
        [HttpGet("{id}")]
        public ActionResult<RehabilitationPrograms> Get(int id)
        {
            var x = DataContext.rehabilitationPrograms.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                return x;
            }
        }
        // POST api/<RehabilitationProgramsController>
        [HttpPost]
        public void Post([FromBody] RehabilitationPrograms value)
        {
            DataContext.rehabilitationPrograms.Add(new RehabilitationPrograms { Id = value.Id, Programs = value.Programs, Moderator = value.Moderator, DayOfWeek = value.DayOfWeek, LengthInMonths = value.LengthInMonths });
        }

        // PUT api/<RehabilitationProgramsController>/5
        [HttpPut("{id}")]
        public ActionResult<RehabilitationPrograms> Put(int id, [FromBody] RehabilitationPrograms value)
        {
            var x = DataContext.rehabilitationPrograms.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                x.Id = value.Id;
                x.Programs = value.Programs;
                x.Moderator = value.Moderator;
                x.DayOfWeek = value.DayOfWeek;
                x.LengthInMonths = value.LengthInMonths;
                return x;
            }
        }
        // DELETE api/<RehabilitationProgramsController>/5
        [HttpDelete("{id}")]
        public ActionResult<RehabilitationPrograms> Delete(int id)
        {
            var x = DataContext.rehabilitationPrograms.Find(r => r.Id == id);
            if (x == null)
                return NotFound();
            else
            {
                DataContext.rehabilitationPrograms.Remove(x);
                return NoContent();
            }
        }
    }
}

