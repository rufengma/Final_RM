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

        [HttpPost]
        public async Task<IActionResult> UpdateRoomtype(AddRoomtypeModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddRoomtype");
            }
            var updateRoomtype = await _roomtypeService.UpdateRoomtype(model.Id,model);
            //redirect to login
            return RedirectToAction("AddRoomtype");
        }


        [HttpPost]
        public async Task<IActionResult> DeleteRoomtype(AddRoomtypeModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddRoomtype");
            }
            await _roomtypeService.DeleteRoomtype(model.Id);
            //redirect to login
            return RedirectToAction("AddRoomtype");
        }

        public async Task<IActionResult> SearchRoomtype(AddRoomtypeModel model)
        {
            var existRoomtype = await _roomtypeService.SearchRoomtype(model.Id);
            return View(existRoomtype);
        }


        public async Task<IActionResult> ListRoomtypes()
        {
            var roomtypes = await _roomtypeService.GetAllRoomtypes();

            return View(roomtypes);
        }
    }
}
