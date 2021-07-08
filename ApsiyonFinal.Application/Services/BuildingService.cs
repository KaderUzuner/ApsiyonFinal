using Apsiyon.Domain.Models;
using Apsiyon.Infrastructure.UnitofWork;
using ApsiyonFinal.Application.DTOs;
using ApsiyonFinal.Application.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.Services
{
    public class BuildingService : IBuildingService

    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public BuildingService(IUnitofWork unitofWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task Add(BuildingViewDto entity)
        {
            await _unitofWork.building.Add(_mapper.Map<Building>(entity));
            await _unitofWork.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            _mapper.Map<BuildingViewDto>(id);
        }

        public async Task<List<BuildingViewDto>> GetAll()
        {
            var result = await _unitofWork.apartment.GetAll();
            return _mapper.Map<List<BuildingViewDto>>(result);
        }

        public void Update(BuildingViewDto entity)
        {
            _mapper.Map<BuildingViewDto>(entity);
        }
    }
}
