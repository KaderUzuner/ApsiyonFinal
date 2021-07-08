using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Model
{

    public class IncomeExpense
    {
        public int Id { get; set; }
        public float Dues { get; set; }
        public float Electricity { get; set; }
        public float Naturalgas { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}



