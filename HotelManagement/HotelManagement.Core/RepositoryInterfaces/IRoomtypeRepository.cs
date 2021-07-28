using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;

namespace HotelManagement.Core.RepositoryInterfaces
{
    public interface IRoomtypeRepository : IAsyncRepository<Roomtype>
    {
        Task<Roomtype> UpdateRoomtype(int id, AddRoomtypeModel model);
    }
}