using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
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
       
    }
}
