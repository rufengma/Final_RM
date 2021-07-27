using System;
using System.Threading.Tasks;
using HotelManagement.Core.Models;

namespace HotelManagement.Core.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<bool> AddRoom(AddRoomModel requestRoom);
    }
}
