using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NeveTirzhaPrisoner.API.Models;
using NeveTirzhaPrisoner.Core.DTOs;
using NeveTirzhaPrisoner.Core.Services;
using NeveTirzhaPrisoner.Service;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeveTirzahPrison.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrisonerController : ControllerBase
    {
        private readonly IPrisonerService _prisonerService;
        private readonly IMapper _mapper;

        public PrisonerController(IPrisonerService prisonerService, IMapper mapper)
        {
            _prisonerService = prisonerService;
            _mapper = mapper;
        }

        // GET: api/<PrisonerController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mapper.Map<IEnumerable<PrisonerDTO>>(_prisonerService.Get()));
        }

        // GET api/<PrisonerController>/5
        [HttpGet("{id}")]
        public ActionResult<Prisoner> Get(int id)
        {
            var x = _prisonerService.GetById(id);
            if (x == null)
                return NotFound();
            else
            {
                return x;
            }
        }

        // POST api/<PrisonerController>
        [HttpPost]
        public void Post([FromBody] PrisonerPostModel value)
        {
            var p=new Prisoner { Name = value.Name, DateBirth = value.DateBirth, YearsInPrison = value.YearsInPrison, Religion = value.Religion };
            _prisonerService.Post(p);   
        }

        // PUT api/<PrisonerController>/5
        [HttpPut("{id}")]
        public ActionResult<Prisoner> Put(int id, [FromBody] PrisonerPostModel value)
        {
            var p = new Prisoner { Name = value.Name, DateBirth = value.DateBirth, YearsInPrison = value.YearsInPrison, Religion = value.Religion };
            if (p == null)
                return NotFound();
            else
            {
                p.Name = value.Name;
                p.DateBirth = value.DateBirth;
                if ((p.YearsInPrison - value.YearsInPrison) > 0)
                    p.YearsInPrison -= value.YearsInPrison;
                else Delete(p.Id);
                p.YearsInPrison = value.YearsInPrison;
                p.Religion = value.Religion;
                return Ok(_prisonerService.Put(id,p));
            }
        }

        // DELETE api/<PrisonerController>/5
        [HttpDelete("{id}")]
        public ActionResult<Prisoner> Delete(int id)
        {
            _prisonerService.Delete(id);
            return Ok();
        }
    }
}

