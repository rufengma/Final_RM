using System;
using HotelManagement.Core.Entities;
using HotelManagement.Core.RepositoryInterfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Core.Models;
namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomtypeRepository : EfRepository<Roomtype>, IRoomtypeRepository
    {
        public RoomtypeRepository(HotelDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<Roomtype> UpdateRoomtype(int id, AddRoomtypeModel model) {
            var local = _dbContext.Rooms.Local.FirstOrDefault(r => r.Id == id);
            if (local != null) _dbContext.Entry(local).State = EntityState.Detached;
            var entity = new Roomtype
            {
                Id = id,
                RTDesc=model.RTDesc,
                Rent=model.Rent
            };
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
