using ApsiyonFinal.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.Interfaces
{
    public interface IApartmentService
    {
        Task Add(ApartmentViewDto entity);
        void Delete(int id);
        void Update(ApartmentViewDto entity);
        Task<List<ApartmentViewDto>> GetAll();
        Task<List<ApartmentViewDto>> Get(Expression<Func<ApartmentViewDto, bool>> filter);
    }
}
