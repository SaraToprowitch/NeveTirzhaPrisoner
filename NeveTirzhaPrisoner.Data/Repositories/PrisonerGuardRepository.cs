using NeveTirzahPrison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeveTirzhaPrisoner.Core;
using NeveTirzhaPrisoner.Core.Repositories;

namespace NeveTirzhaPrisoner.Data.Repositories
{
    public class PrisonerGuardRepository:IPrisonerGuardRepository
    {
        private readonly DataContext _context;
        public PrisonerGuardRepository(DataContext context)
        {
            _context = context;
        }

        public List<PrisonGuard> Get()
        {
            return _context.prisonGuards.ToList();
        }

        public PrisonGuard GetById(int id)
        {
            return _context.prisonGuards.ToList().Find(p => p.Id == id);
        }

        public PrisonGuard Post(PrisonGuard prisonGuard)
        {
            _context.prisonGuards.Add(prisonGuard);
            _context.SaveChanges();
            return prisonGuard;
        }

        public PrisonGuard Put(int id, PrisonGuard prisonGuard)
        {
            var updatePrisonerGuard = _context.prisonGuards.ToList().Find(d => d.Id == id);
            if (updatePrisonerGuard != null)
            {
                updatePrisonerGuard.Name = prisonGuard.Name;
                updatePrisonerGuard.ShiftTime = prisonGuard.ShiftTime;
                updatePrisonerGuard.HourlySalary = prisonGuard.HourlySalary;
                updatePrisonerGuard.Role=prisonGuard.Role;

                _context.SaveChanges();
                return updatePrisonerGuard;
            }
            return null;
        }

        public void Delete(int id)
        {
            _context.prisonGuards.Remove(_context.prisonGuards.ToList().Find(x => x.Id == id));
            _context.SaveChanges();
        }

    }
}
