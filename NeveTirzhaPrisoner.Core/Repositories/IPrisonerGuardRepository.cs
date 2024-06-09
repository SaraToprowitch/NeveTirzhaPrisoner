﻿using NeveTirzahPrison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveTirzhaPrisoner.Core.Repositories
{
    public interface IPrisonerGuardRepository
    {
        List<PrisonGuard> Get();

        PrisonGuard GetById(int id);

        PrisonGuard Post(PrisonGuard prisonGuard);

        PrisonGuard Put(int id, PrisonGuard prisonGuard);

        void Delete(int id);

    }
}
