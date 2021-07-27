using System;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
using HotelManagement.Core.RepositoryInterfaces;
using HotelManagement.Core.ServiceInterfaces;
namespace HotelManagement.Infrastructure.Services
{
    public class RoomtypeService:IRoomtypeService
    {
        private readonly IRoomtypeRepository _roomtypeRepository;
        public RoomtypeService(IRoomtypeRepository roomtypeRepository)
        {
            _roomtypeRepository = roomtypeRepository;
        }
        public async Task<bool> AddRoomtype(AddRoomtypeModel requestRoomtype)
        {

            var roomtype = new Roomtype
            {
                Id = requestRoomtype.Id,
                RTDesc=requestRoomtype.RTDesc,
                Rent=requestRoomtype.Rent
            };
            var createdRoomtype = await _roomtypeRepository.AddAsync(roomtype);
            if (createdRoomtype != null && createdRoomtype.Id > 0)
            {
                return true;
            }
            return false;
        }
    }
}
