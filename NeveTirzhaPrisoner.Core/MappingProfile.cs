using AutoMapper;
using NeveTirzahPrison;
using NeveTirzhaPrisoner.Core.DTOs;
using NeveTirzhaPrisoner.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveTirzhaPrisoner.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PrisonerDTO, Prisoner>().ReverseMap();
            CreateMap<PrisonerGuardDTO, PrisonGuard>().ReverseMap();
            CreateMap<RehabilitationProgramsDTO, RehabilitationPrograms>().ReverseMap();
        }
    }
}
