using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NeveTirzhaPrisoner.API.Models;
using NeveTirzhaPrisoner.Core.DTOs;
using NeveTirzhaPrisoner.Core.Services;
using NeveTirzhaPrisoner.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeveTirzahPrison.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RehabilitationProgramsController : ControllerBase
    {
        private readonly IRehabilitationProgramsService _rehabilitationProgramsService;
        private readonly IMapper _mapper;
        public RehabilitationProgramsController(IRehabilitationProgramsService rehabilitationPrograms, IMapper mapper)
        {
            _rehabilitationProgramsService = rehabilitationPrograms;
            _mapper = mapper;
        }
        //GET: api/<PrisonerGuardController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mapper.Map<IEnumerable<RehabilitationProgramsService>>(_rehabilitationProgramsService.Get()));
        }

        //GET api/<RehabilitationProgramsController>/5
        [HttpGet("{id}")]
        public ActionResult<RehabilitationPrograms> Get(int id)
        {
            var x = _rehabilitationProgramsService.GetById(id);
            if (x == null)
                return NotFound();
            else
            {
                return x;
            }
        }
        // POST api/<RehabilitationProgramsController>
        [HttpPost]
        public void Post([FromBody] RehabilitationProgramsPostModel value)
        {
            var r = new RehabilitationPrograms { Programs = value.Programs, Moderator = value.Moderator, DayOfWeek = value.DayOfWeek, LengthInMonths = value.LengthInMonths };
            _rehabilitationProgramsService.Post(r);
        }

        // PUT api/<RehabilitationProgramsController>/5
        [HttpPut("{id}")]
        public ActionResult<RehabilitationPrograms> Put(int id, [FromBody] RehabilitationProgramsPostModel value)
        {
            var r = new RehabilitationPrograms { Programs = value.Programs, Moderator = value.Moderator, DayOfWeek = value.DayOfWeek, LengthInMonths = value.LengthInMonths };
            if (r == null)
                return NotFound();
            else
            {
                r.Programs = value.Programs;
                r.Moderator = value.Moderator;
                r.DayOfWeek = value.DayOfWeek;
                r.LengthInMonths = value.LengthInMonths;
                return Ok(_rehabilitationProgramsService.Put(id, r));
            }
        }
        // DELETE api/<RehabilitationProgramsController>/5
        [HttpDelete("{id}")]
        public ActionResult<RehabilitationPrograms> Delete(int id)
        {
            _rehabilitationProgramsService.Delete(id);
            return Ok();
        }
    }
}

