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

        [HttpPost]
        public async Task<IActionResult> UpdateRoom(AddRoomModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddRoom");
            }
            var updateRoom = await _roomService.UpdateRoom(model.Id, model);
            //redirect to login
            return RedirectToAction("AddRoom");
        }


        [HttpPost]
        public async Task<IActionResult> DeleteRoom(AddRoomModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddRoom");
            }
            await _roomService.DeleteRoom(model.Id);
            //redirect to login
            return RedirectToAction("AddRoom");
        }

        public async Task<IActionResult> SearchRoom(AddRoomModel model)
        {
            var existRoom = await _roomService.SearchRoom(model.Id);
            return View(existRoom);
        }
    }
}
