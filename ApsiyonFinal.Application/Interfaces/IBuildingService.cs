using ApsiyonFinal.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.Interfaces
{
    public interface IBuildingService
    {
        Task Add(BuildingViewDto entity);
        void Delete(int id);
        void Update(BuildingViewDto entity);
        Task<List<BuildingViewDto>> GetAll();
    }
}
