using System;
using System.Threading.Tasks;
using HotelManagement.Core.Models;
using HotelManagement.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.MVC.Controllers
{
    public class RoomtypeController : Controller
    {
        private readonly IRoomtypeService _roomtypeService;
        public RoomtypeController(IRoomtypeService roomtypeService)
        {
            _roomtypeService = roomtypeService;
        }

        [HttpGet]
        public IActionResult AddRoomtype()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoomtype(AddRoomtypeModel roomtypeModel)
        {
            var createService = await _roomtypeService.AddRoomtype(roomtypeModel);
            return LocalRedirect("~/");
        }
    }
}
