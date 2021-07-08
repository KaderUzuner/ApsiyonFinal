using Apsiyon.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.UnitofWork
{
    public interface IUnitofWork
    {
        IApartmentRepository apartment { get; } 
        IBuildingRepository building { get; }
        IIncomeExpenseRepository ıncomeExpense { get; }
        Task<int> SaveChangesAsync(); 
    }
}
