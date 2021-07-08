using ApsiyonFinal.Application.Interfaces;
using ApsiyonFinal.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonFinal.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApartmentService _apartmentService = null;
        public HomeController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Apartment()
        {
            var model = new ApartmentViewModel();
            model.Apartments = await _apartmentService.GetAll();
            return View(model);

        }

        public IActionResult Detail(int apartmentId)
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

