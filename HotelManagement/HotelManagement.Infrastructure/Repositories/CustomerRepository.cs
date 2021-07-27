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
    public class CustomerRepository : EfRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(HotelDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            var entity = await _dbContext.Customers.Include(c => c.Room).ThenInclude(r => r.Services).FirstOrDefaultAsync(c => c.Id == id);
            return entity;
        }
    }
}
