using ApsiyonFinal.Application.DTOs;
using ApsiyonFinal.Application.Interfaces;
using ApsiyonFinal.Web.SessionExtension;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonFinal.Web.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ICreditCardService _creditCardService;
        public PaymentController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Payment()
        {

            var currentBasket = HttpContext.Session.Get<BasketViewDto>("basket");

            return View(currentBasket);
        }

        [HttpPost]
        public async Task<IActionResult> Payment(CreditCardDto creditCard)
        {
            bool result = await _creditCardService.WithdrawMoney(creditCard);
            return View();
        }

        public IActionResult Basket()
        {
            var currentBasket = HttpContext.Session.Get<BasketViewDto>("basket");

            return View(currentBasket);
        }

        public IActionResult BasketAdd(int id)
        {
            var currentBasket = HttpContext.Session.Get<BasketViewDto>("basket");
            if (currentBasket == default)
            {
                BasketViewDto basketView = new BasketViewDto();
                basketView = new List<BasketItemViewDto>();
                basketView.Add(new BasketItemViewDto { ApartmentId = id, Piece = 1, Price = 200 });

                HttpContext.Session.Set<BasketViewDto>("basket", basketView);
            }
            else
            {
                var currentItem = currentBasket.FirstOrDefault(x => x.ApartmentId == id);
                if (currentItem == null)
                {
                    currentBasket.Add(new BasketViewDto { ApartmentId = id });


                }
                else
                {
                    currentItem.Piece++;
                }

                HttpContext.Session.Set<BasketViewDto>("basket", currentBasket);
            }


            return Ok(new { status = true });
        }
    }
}
