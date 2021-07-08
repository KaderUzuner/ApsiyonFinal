using ApsiyonFinal.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.Interfaces
{
     public  interface IIncomeExpenseService
    {
        Task<List<IncomeExpenseViewDto>> GetAll();
        Task<IncomeExpenseViewDto> GetById(int id);
        Task<List<IncomeExpenseViewDto>> Get(Expression<Func<IncomeExpenseViewDto, bool>> filter);
    }
}
