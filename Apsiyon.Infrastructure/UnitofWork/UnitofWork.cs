using Apsiyon.Domain.Interface;
using Apsiyon.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.UnitofWork
{
    public class UnitofWork:IUnitofWork
    {
        public IApartmentRepository apartment { get; }
        public IBuildingRepository building { get; }
        public IIncomeExpenseRepository IncomeExpense { get; }

        public IIncomeExpenseRepository ıncomeExpense => throw new NotImplementedException();

        private readonly ApsiyonContext _context;
        public UnitofWork(ApsiyonContext context,  IApartmentRepository apartmentRepository, IBuildingRepository buildingRepository, IIncomeExpenseRepository ıncomeExpenseRepository)
        {
            _context = context;
            apartment = apartmentRepository;
            building = buildingRepository;
            IncomeExpense = ıncomeExpenseRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
