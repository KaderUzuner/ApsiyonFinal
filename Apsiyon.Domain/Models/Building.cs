using Apsiyon.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Domain.Models
{
    public class Building
    {
        public int BuildingId { get; set; }
        public char BuildingName { get; set; }
        public virtual  ICollection<Apartment> Apartments { get; set; }
    }
}
