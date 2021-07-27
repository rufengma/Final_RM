using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Core.ServiceInterfaces;
using HotelManagement.Infrastructure.Services;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelManagement.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> Detail(int id)
        {
            var customer = await _customerService.GetCustomerById(id);
            return View(customer);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(AddCustomerModel customerModel)
        {
            var createCustomer = await _customerService.AddCustomer(customerModel);
            return LocalRedirect("~/");
        }
        public IActionResult EditCustomer()
        {
            return View();
        }
    }
}
