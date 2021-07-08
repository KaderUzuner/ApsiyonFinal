using Apsiyon.Domain.Model;
using ApsiyonFinal.Application.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.Profiles
{
    public class IncomeExpenseProfile:Profile
    {
        public IncomeExpenseProfile()
        {
            CreateMap<IncomeExpenseViewDto, IncomeExpense>().ReverseMap();
        }
    }
}
