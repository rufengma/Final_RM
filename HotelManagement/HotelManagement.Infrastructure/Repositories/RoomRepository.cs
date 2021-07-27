using System;
using HotelManagement.Core.Entities;
using HotelManagement.Core.RepositoryInterfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomRepository : EfRepository<Room>, IRoomRepository
    {
        public RoomRepository(HotelDbContext dbContext) : base(dbContext)
        {
        }
    }
}
