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
        public async Task<Customer> UpdateCustomer(int id, AddCustomerModel model)
        {
            var local = _dbContext.Customers.Local.FirstOrDefault(r => r.Id == id);
            if (local != null) _dbContext.Entry(local).State = EntityState.Detached;
            var entity = new Customer
            {
                Id = id,
                RoomNo=model.RoomNo,
                CName=model.CName,
                Address=model.Address,
                Phone=model.Phone,
                Email=model.Email,
                Checkin=model.Checkin,
                TotalPersons=model.TotalPersons,
                BookingDays=model.BookingDays,
                Advance=model.Advance
            };
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
