using Apsiyon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Model
{
    public class Apartment
    {
        public virtual Building BuildingId { get; set; }
        public bool Status { get; set; }
        public int NumberofRooms { get; set; }
        public int Floor { get; set; }
        public int  ApartmentNumber { get; set; }
        public virtual User User { get; set; }
        public virtual IncomeExpense IncomeExpense { get; set; }
    }
}
