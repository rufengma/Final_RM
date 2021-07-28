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

        [HttpPost]
        public async Task<IActionResult> UpdateService(AddServiceModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddService");
            }
            var updateService = await _serviceService.UpdateService(model.Id, model);
            //redirect to login
            return RedirectToAction("AddService");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteService(AddServiceModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddService");
            }
            await _serviceService.DeleteService(model.Id);
            //redirect to login
            return RedirectToAction("AddService");
        }

        public async Task<IActionResult> SearchService(AddServiceModel model)
        {
            var existService = await _serviceService.SearchService(model.Id);
            return View(existService);
        }
    }
}
