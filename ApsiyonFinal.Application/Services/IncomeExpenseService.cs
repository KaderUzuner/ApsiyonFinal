
using Apsiyon.Domain.Model;
using Apsiyon.Infrastructure.UnitofWork;
using ApsiyonFinal.Application.DTOs;
using ApsiyonFinal.Application.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.Services
{
    public class IIncomeService : IIncomeExpenseService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public IIncomeService(IUnitofWork unitofWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<List<IncomeExpenseViewDto>> Get(Expression<Func<IncomeExpenseViewDto, bool>> filter)
        {
           var result = _mapper.Map<Expression<Func<IncomeExpense, bool>>>(filter);
            var res = await _unitofWork.ıncomeExpense.Get(result);
            return _mapper.Map<List<IncomeExpenseViewDto>>(result);
        }

        public async Task<List<IncomeExpenseViewDto>> GetAll()
        {
            var result = await _unitofWork.apartment.GetAll();
            return _mapper.Map<List<IncomeExpenseViewDto>>(result);
        }

        public Task<IncomeExpenseViewDto> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}