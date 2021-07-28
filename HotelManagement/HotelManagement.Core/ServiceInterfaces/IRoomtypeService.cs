using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
namespace HotelManagement.Core.ServiceInterfaces
{
    public interface IRoomtypeService
    {
        Task<bool> AddRoomtype(AddRoomtypeModel requestRoomtype);
        Task<Roomtype> UpdateRoomtype(int id, AddRoomtypeModel requestRoomtype);
        Task DeleteRoomtype(int id);
        Task<Roomtype> SearchRoomtype(int id);
        Task<List<Roomtype>> GetAllRoomtypes();
    }
}
