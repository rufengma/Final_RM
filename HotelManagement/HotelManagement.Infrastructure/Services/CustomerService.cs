using System;
using HotelManagement.Core.ServiceInterfaces;
using HotelManagement.Core.RepositoryInterfaces;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using System.Collections.Generic;
using HotelManagement.Core.Models;

namespace HotelManagement.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> GetAllCustomers()//this is entity
        {
            var customers = await _customerRepository.ListAllAsync();
            return customers;
        }
        public async Task<CustomerDetailResponseModel> GetCustomerById(int id)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(id);
            var customerDetails = new CustomerDetailResponseModel()
            {
                Id = customer.Id,
                RoomNo = customer.RoomNo,
                CName = customer.CName,
                Address = customer.Address,
                Phone = customer.Phone,
                Email = customer.Email,
                Checkin = customer.Checkin,
                TotalPersons = customer.TotalPersons,
                BookingDays = customer.BookingDays,
                Advance = customer.Advance
            };
            customerDetails.roomModel = new RoomModel();
            customerDetails.roomModel.Id = customer.Room.Id;
            customerDetails.roomModel.RTCode = customer.Room.RTCode;
            customerDetails.roomModel.serviceModels = new List<ServiceModel>();
            foreach (var ser in customer.Room.Services)
            {
                customerDetails.roomModel.serviceModels.Add(
                    new ServiceModel
                    {
                        Id = ser.Id,
                        RoomNo = ser.RoomNo,
                        SDesc = ser.SDesc

                    });

            }
            return customerDetails;
    }

    }
}
