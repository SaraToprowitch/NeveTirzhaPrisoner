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
    public class PrisonerRepository : IPrisonerRepository
    {
        private readonly DataContext _context;
        public PrisonerRepository(DataContext context)
        {
            _context = context;
        }


        public List<Prisoner> Get()
        {
            return _context.prisoners.ToList();
        }

        public Prisoner GetById(int id)
        {
            return _context.prisoners.ToList().Find(p => p.Id == id);
        }

        public Prisoner Post(Prisoner prisoner)
        {
            _context.prisoners.Add(prisoner);
            _context.SaveChanges();
            return prisoner;
        }

        public Prisoner Put(int id, Prisoner prisoner)
        {
            var updatePrisoner = _context.prisoners.ToList().Find(d => d.Id == id);
            if (updatePrisoner != null)
            {
                updatePrisoner.Name = prisoner.Name;
                updatePrisoner.DateBirth = prisoner.DateBirth;
                updatePrisoner.PrisonGuard = prisoner.PrisonGuard;
                updatePrisoner.YearsInPrison = prisoner.YearsInPrison;
                updatePrisoner.Religion = prisoner.Religion;

                _context.SaveChanges();
                return updatePrisoner;
            }
            return null;
        }

        public void Delete(int id)
        {
            _context.prisoners.Remove(_context.prisoners.ToList().Find(x => x.Id == id));
            _context.SaveChanges();
        }
    }
}