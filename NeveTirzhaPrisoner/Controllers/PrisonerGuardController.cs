using Microsoft.AspNetCore.Mvc;
using NeveTirzhaPrisoner.Core.Services;
using NeveTirzahPrison;
using System;
using AutoMapper;
using NeveTirzhaPrisoner.Core.DTOs;
using NeveTirzhaPrisoner.Service;
using NeveTirzhaPrisoner.API.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeveTirzahPrison.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrisonerGuardController : ControllerBase
    {
        private readonly IPrisonerGuardService _prisonerGuardService;
        private readonly IMapper _mapper;
        public PrisonerGuardController(IPrisonerGuardService prisonerGuard, IMapper mapper)
        {
            _prisonerGuardService = prisonerGuard;
            _mapper = mapper;
        }
        //GET: api/<PrisonerGuardController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mapper.Map<IEnumerable<PrisonerGuardDTO>>(_prisonerGuardService.Get()));
        }

        // GET api/<PrisonerGuardController>/5
        [HttpGet("{id}")]
        public ActionResult<PrisonGuard> Get(int id)
        {
            var x = _prisonerGuardService.GetById(id);
            if (x == null)
                return NotFound();
            else
            {
                return x;
            }
        }


        // POST api/<PrisonerGuardController>
        [HttpPost]
        public void Post([FromBody] PrisonerGuardPostModel value)
        {
            var p = new PrisonGuard { Name = value.Name, Role = value.Role, ShiftTime = value.ShiftTime, HourlySalary = value.HourlySalary };
            _prisonerGuardService.Post(p);
        }

        // PUT api/<PrisonerGuardController>/5
        [HttpPut("{id}")]
        public ActionResult<PrisonGuard> Put(int id, [FromBody] PrisonerGuardPostModel value)
        {
            var p = new PrisonGuard { Name = value.Name, Role = value.Role, ShiftTime = value.ShiftTime, HourlySalary = value.HourlySalary };
            if (p == null)
                return NotFound();
            else
            {
                p.Name = value.Name;
                p.Role = value.Role;
                p.ShiftTime = value.ShiftTime;
                if (value.ShiftTime == Shift.night)
                    p.HourlySalary = value.HourlySalary + 25;
                else
                    p.HourlySalary = value.HourlySalary;
                return Ok(_prisonerGuardService.Put(id, p));
            }
        }

        // DELETE api/<PrisonerGuardController>/5
        [HttpDelete("{id}")]
        public ActionResult<PrisonGuard> Delete(int id)
        {
            _prisonerGuardService.Delete(id);
            return Ok();
        }

    }
}
