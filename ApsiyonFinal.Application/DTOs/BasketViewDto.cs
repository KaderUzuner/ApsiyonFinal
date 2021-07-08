using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.DTOs
{
    public class BasketViewDto
    {
     
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public string UserName { get; set; }
        public Guid UserId { get; set; }

    }
    public class BasketItemViewDto
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public string IncomeExpenseId { get; set; }
        public float Price { get; set; }
        public int Piece { get; set; }

        public float Total => Price * Piece;

    }
}