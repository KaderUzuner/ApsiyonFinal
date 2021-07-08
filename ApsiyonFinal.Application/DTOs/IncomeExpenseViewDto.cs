using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.DTOs
{
    public class IncomeExpenseViewDto
    {
        public int Id { get; set; }
        public float Dues { get; set; }
        public float Electricity { get; set; }
        public float Naturalgas { get; set; }
        public Guid UserId { get; set; }
     
    }
}
