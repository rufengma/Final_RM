using System;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
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
        public async Task<Room> UpdateRoom(int id, AddRoomModel model)
        {
            var local = _dbContext.Rooms.Local.FirstOrDefault(r => r.Id == id);
            if (local != null) _dbContext.Entry(local).State = EntityState.Detached;
            var entity = new Room
            {
                Id = id,
                RTCode = model.RTCode,
                status = model.status
            };
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
