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
    public class PrisonerService : IPrisonerService
    {
        private readonly IPrisonerRepository _prisonerRepository;

        public PrisonerService(IPrisonerRepository prisonerRepository)
        {
            _prisonerRepository = prisonerRepository;
        }

        public void Delete(int id)
        {
            _prisonerRepository.Delete(id);
        }

        public List<Prisoner> Get()
        {
            return _prisonerRepository.Get();
        }

        public Prisoner GetById(int id)
        {
            return _prisonerRepository.GetById(id);
        }


        public Prisoner Post(Prisoner prisoner)
        {
            return _prisonerRepository.Post(prisoner);
        }

        public Prisoner Put(int id, Prisoner prisoner)
        {
            return _prisonerRepository.Put(id, prisoner);
        }
    }
}
