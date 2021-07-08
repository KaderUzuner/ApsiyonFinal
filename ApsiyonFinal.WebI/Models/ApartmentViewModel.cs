using ApsiyonFinal.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonFinal.WebI.Models
{
    public class ApartmentViewModel
    {
        public List<BuildingViewDto> Buildings { get; set; }
        public List<ApartmentViewDto> Apartments { get; set; }
    }
}
