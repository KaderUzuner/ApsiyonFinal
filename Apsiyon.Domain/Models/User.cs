using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Model
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
        public string Mail { get; set; }
        public int Phonenumber { get; set; }
        public string CarLicensePlate { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual ICollection<IncomeExpense> IncomeExpenses { get; set; }
    }
}