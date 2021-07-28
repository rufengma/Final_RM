using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
namespace HotelManagement.Core.RepositoryInterfaces
{
    public interface IRoomRepository : IAsyncRepository<Room>
    {
        Task<Room> UpdateRoom(int id, AddRoomModel model);
    }
}