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
    public class RehabilitationProgramsRepository : IRehabilitationProgramsRepository
    {
        private readonly DataContext _context;
        public RehabilitationProgramsRepository(DataContext context)
        {
            _context = context;
        }

        public List<RehabilitationPrograms> Get()
        {
            return _context.rehabilitationPrograms.ToList();
        }

        public RehabilitationPrograms GetById(int id)
        {
            return _context.rehabilitationPrograms.ToList().Find(x => x.Id == id);
        }

        public RehabilitationPrograms Post(RehabilitationPrograms program)
        {
            _context.rehabilitationPrograms.Add(program);
            _context.SaveChanges();
            return program;
        }

        public RehabilitationPrograms Put(int id, RehabilitationPrograms program)
        {
            var existProgram = GetById(id);
            if (existProgram != null)
            {
                existProgram.Programs = program.Programs;
                existProgram.Moderator = program.Moderator;
                existProgram.LengthInMonths = program.LengthInMonths;
                existProgram.MaxNumOfPrisoners = program.MaxNumOfPrisoners;
                existProgram.CurrentNumOfPrisoners = program.CurrentNumOfPrisoners;
                existProgram.DayOfWeek = program.DayOfWeek;

                _context.SaveChanges();
                return existProgram;
            }
            return null;
        }

        public void Delete(int id)
        {
            _context.rehabilitationPrograms.Remove(GetById(id));
            _context.SaveChanges();
        }


    }
}
