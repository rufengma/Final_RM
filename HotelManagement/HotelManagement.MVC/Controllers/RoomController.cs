using System;
using System.Threading.Tasks;
using HotelManagement.Core.Models;
using HotelManagement.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.MVC.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(AddRoomModel roomModel)
        {
            var createService = await _roomService.AddRoom(roomModel);
            return LocalRedirect("~/");
        }
    }
}
