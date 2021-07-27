using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;

namespace HotelManagement.Core.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();
        Task<CustomerDetailResponseModel> GetCustomerById(int id);
        Task<bool> AddCustomer(AddCustomerModel requestCustomer);
    }
}
