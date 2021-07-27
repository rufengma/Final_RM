using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;

namespace HotelManagement.Core.RepositoryInterfaces
{
    public interface IRoomRepository : IAsyncRepository<Room>
    {
    }
}