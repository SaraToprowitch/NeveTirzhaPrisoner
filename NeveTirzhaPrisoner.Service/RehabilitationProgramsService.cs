using NeveTirzahPrison;
using NeveTirzhaPrisoner.Core.Repositories;
using NeveTirzhaPrisoner.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveTirzhaPrisoner.Service
{
    public class RehabilitationProgramsService : IRehabilitationProgramsService
    {

        private readonly IRehabilitationProgramsRepository _rehabilitationProgramsRepository;

        public RehabilitationProgramsService(IRehabilitationProgramsRepository rehabilitationProgramsRepository)
        {
            _rehabilitationProgramsRepository = rehabilitationProgramsRepository;
        }


        public RehabilitationPrograms GetById(int id)
        {
            return _rehabilitationProgramsRepository.GetById(id);
        }

        public RehabilitationPrograms Post(RehabilitationPrograms program)
        {
            return _rehabilitationProgramsRepository.Post(program);
        }

        public RehabilitationPrograms Put(int id, RehabilitationPrograms program)
        {
            return _rehabilitationProgramsRepository.Put(id, program);
        }

        public void Delete(int id)
        {
            _rehabilitationProgramsRepository.Delete(id);
        }

        public List<RehabilitationPrograms> Get()
        {
            return _rehabilitationProgramsRepository.Get();
        }
    }
}
