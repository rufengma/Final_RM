using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
using HotelManagement.Core.RepositoryInterfaces;
using HotelManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelManagement.Infrastructure.Repositories
{
    public class ServiceRepository : EfRepository<Service>, IServiceRepository
    {
        public ServiceRepository(HotelDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<Service> UpdateService(int id, AddServiceModel model)
        {
            var local = _dbContext.Services.Local.FirstOrDefault(r => r.Id == id);
            if (local != null) _dbContext.Entry(local).State = EntityState.Detached;
            var entity = new Service
            {
                Id = id,
                RoomNo = model.RoomNo,
                SDesc = model.SDesc,
                Amount=model.Amount,
                ServiceDate=model.ServiceDate    
            };
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

    }
}
