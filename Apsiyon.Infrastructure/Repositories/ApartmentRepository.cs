using Apsiyon.Domain.Interface;
using Apsiyon.Domain.Model;
using Apsiyon.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.Repositories
{
    public class ApartmentRepository:Repository<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(ApsiyonContext context): base(context)
        {

        }
    }
}
