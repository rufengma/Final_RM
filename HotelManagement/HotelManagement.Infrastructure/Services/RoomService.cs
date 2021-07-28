using System;
using System.Collections.Generic;
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
        public async Task<Room> UpdateRoom(int id, AddRoomModel requestRoom)
        {
            return await _roomRepository.UpdateRoom(id, requestRoom);
        }

        public async Task DeleteRoom(int id)
        {
            await _roomRepository.DeleteAsync(id);
        }
        public async Task<Room> SearchRoom(int id)
        {
            return await _roomRepository.GetByIdAsync(id);
        }
        public async Task<List<Room>> GetAllRooms()//this is entity
        {
            var Rooms = await _roomRepository.ListAllAsync();
            return Rooms;
        }
    }
}
