using Apsiyon.Domain.Interface;
using Apsiyon.Domain.Models;
using Apsiyon.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.Repositories
{
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        public BuildingRepository(ApsiyonContext context): base(context)
        {

        }

    }
}
