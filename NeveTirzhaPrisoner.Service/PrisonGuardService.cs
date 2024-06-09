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
    public class PrisonGuardService : IPrisonerGuardService
    {
        private readonly IPrisonerGuardRepository _prisonerGuardRepository;

        public PrisonGuardService(IPrisonerGuardRepository prisonerGuardRepository)
        {
            _prisonerGuardRepository = prisonerGuardRepository;
        }

        public void Delete(int id)
        {
            _prisonerGuardRepository.Delete(id);
        }

        public List<PrisonGuard> Get()
        {
            return _prisonerGuardRepository.Get();
        }

        public PrisonGuard GetById(int id)
        {
            return _prisonerGuardRepository.GetById(id);
        }

        public PrisonGuard Post(PrisonGuard prisonGuard)
        {
            return _prisonerGuardRepository.Post(prisonGuard);
        }

        public PrisonGuard Put(int id, PrisonGuard prisonGuard)
        {
            return _prisonerGuardRepository.Put(id, prisonGuard);
        }
    }
}
