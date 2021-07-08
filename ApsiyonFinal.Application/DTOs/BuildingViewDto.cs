using Apsiyon.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.DTOs
{
    public class BuildingViewDto
    {
        public int BuildingId { get; set; }
        public char BuildingName { get; set; }
        public virtual ApartmentViewDto Apartment { get; set; }
    }
}
