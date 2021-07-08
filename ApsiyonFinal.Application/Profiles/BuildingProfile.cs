using Apsiyon.Domain.Models;
using ApsiyonFinal.Application.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApsiyonFinal.Application.Profiles
{
    public class BuildingProfile : Profile 
    {
        public BuildingProfile()
        {
            CreateMap<BuildingViewDto, Building>().ReverseMap();
        }
      
    }
}
