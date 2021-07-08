using ApsiyonFinal.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.Interfaces
{
    public interface ICreditCardService
    {
        Task<bool> WithdrawMoney(CreditCardDto creditCard);
    }
}
