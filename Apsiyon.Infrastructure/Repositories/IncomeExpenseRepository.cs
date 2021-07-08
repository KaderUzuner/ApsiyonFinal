using Apsiyon.Domain.Interface;
using Apsiyon.Domain.Model;
using Apsiyon.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.Repositories
{
    public class IncomeExpenseRepository : Repository<IncomeExpense>, IIncomeExpenseRepository
    {
        public IncomeExpenseRepository(ApsiyonContext context):base(context)
        {

        }
    }
}
