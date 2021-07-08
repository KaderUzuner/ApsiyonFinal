using ApsiyonFinal.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.DTOs
{
    public  class ApartmentViewDto
    {
        public virtual BuildingViewDto Building { get; set; }
        public bool Status { get; set; }
        public int NumberofRooms { get; set; }
        public int Floor { get; set; }
        public int ApartmentNumber { get; set; }
        public Guid UserId { get; set; }
        public IncomeExpenseViewDto IncomeExpense { get; set; }
    }
}
