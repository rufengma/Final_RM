using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Core.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelManagement.MVC.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddService(AddServiceModel serviceModel)
        {
            var createService = await _serviceService.AddService(serviceModel);
            return LocalRedirect("~/");
        }
        public IActionResult EditService()
        {
            return View();
        }
    }
}
