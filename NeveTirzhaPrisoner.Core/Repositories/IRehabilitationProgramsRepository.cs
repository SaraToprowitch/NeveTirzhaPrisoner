using NeveTirzahPrison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveTirzhaPrisoner.Core.Repositories
{
    public interface IRehabilitationProgramsRepository
    {
        List<RehabilitationPrograms> Get();

        RehabilitationPrograms GetById(int id);

        RehabilitationPrograms Post(RehabilitationPrograms program);

        RehabilitationPrograms Put(int id, RehabilitationPrograms program);

        void Delete(int id);
    }
}
