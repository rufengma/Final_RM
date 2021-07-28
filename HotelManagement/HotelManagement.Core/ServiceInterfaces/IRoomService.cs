﻿using System;
using System.Threading.Tasks;
using HotelManagement.Core.Models;
using HotelManagement.Core.Entities;
namespace HotelManagement.Core.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<bool> AddRoom(AddRoomModel requestRoom);
        Task<Room> UpdateRoom(int id, AddRoomModel requestRoom);
        Task DeleteRoom(int id);
        Task<Room> SearchRoom(int id);
    }
}
