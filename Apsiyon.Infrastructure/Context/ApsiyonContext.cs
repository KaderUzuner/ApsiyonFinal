using Apsiyon.Domain.Model;
using Apsiyon.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.Context
{
    public class ApsiyonContext : IdentityDbContext<User>
    {
        public ApsiyonContext(DbContextOptions<ApsiyonContext> options) : base(options)
        {
            
        }

        public DbSet<Apartment>Apartments { get; set; } 
        public DbSet<Building> Buildings { get; set; }
        public DbSet<IncomeExpense> IncomeExpenses { get; set; }
    }
}
