using System;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
using HotelManagement.Core.RepositoryInterfaces;
using HotelManagement.Core.ServiceInterfaces;

namespace HotelManagement.Infrastructure.Services
{
    public class RoomService :IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public async Task<bool> AddRoom(AddRoomModel requestRoom)
        {

            var room = new Room
            {
                Id = requestRoom.Id,
                RTCode = requestRoom.RTCode,
                status = requestRoom.status
    
            };
            var createdRoom = await _roomRepository.AddAsync(room);
            if (createdRoom != null && createdRoom.Id > 0)
            {
                return true;
            }

            return false;
        }
    }
}
