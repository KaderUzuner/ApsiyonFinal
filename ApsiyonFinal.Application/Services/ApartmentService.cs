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
    public class ApartmentService : IApartmentService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public ApartmentService(IUnitofWork unitofWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task Add(ApartmentViewDto entity)
        {
            await _unitofWork.apartment.Add(_mapper.Map<Apartment>(entity));
            await _unitofWork.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            _mapper.Map<ApartmentViewDto>(id);
            

        }

        public async Task<List<ApartmentViewDto>> Get(Expression<Func<ApartmentViewDto, bool>> filter)
        {
            var result = _mapper.Map<Expression<Func<Apartment, bool>>>(filter);
            var res = await _unitofWork.apartment.Get(result);
            return _mapper.Map<List<ApartmentViewDto>>(result);
        }

        public async Task<List<ApartmentViewDto>> GetAll()
        {
            var result = await _unitofWork.apartment.GetAll();
            return _mapper.Map<List<ApartmentViewDto>>(result);
        }

        public void Update(ApartmentViewDto entity)
        {
            _mapper.Map<ApartmentViewDto>(entity);
           
        }
    }
}
