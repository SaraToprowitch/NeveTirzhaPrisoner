using NeveTirzahPrison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveTirzhaPrisoner.Core.Repositories
{
    public interface IPrisonerRepository
    {
        List<Prisoner> Get();

        Prisoner GetById(int id);

        Prisoner Post(Prisoner prisoner);

        Prisoner Put(int id, Prisoner prisoner);

        void Delete(int id);
    }


}

