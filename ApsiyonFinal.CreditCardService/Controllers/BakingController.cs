using ApsiyonFinal.CreditCardService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonFinal.CreditCardService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class BankingController : Controller
    {
        private readonly Services.CreditCardService _creditCardService;
        public BankingController(Services.CreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [HttpPost("WithdrawMoney")]
        public async Task<IActionResult> WithdrawMoney(CreditCardViewModel model)
        {
            var result = await _creditCardService.WithdrawMoney(new Model.Mongo.CreditCard
            {
                CardNumber = model.CardNumber,
                Cvv = model.Cvv,
                Owner = model.Owner,
                ValidMonth = model.ValidMonth,
                ValidYear = model.ValidYear
            }, model.Money);
            return Ok(result);
        }
    }
}
