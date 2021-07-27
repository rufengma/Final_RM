using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
using HotelManagement.Core.RepositoryInterfaces;
using HotelManagement.Core.ServiceInterfaces;

namespace HotelManagement.Infrastructure.Services
{
    public class ServiceService: IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public Task<List<Service>> GetAllServices()
        {
            throw new NotImplementedException();
        }
        public async Task<bool> AddService(AddServiceModel requestService)
        {

            var service = new Service
            {
                Id = requestService.Id,
                RoomNo = requestService.RoomNo,
                SDesc = requestService.SDesc,
                Amount=requestService.Amount,
                ServiceDate=requestService.ServiceDate
            };
            var createdService = await _serviceRepository.AddAsync(service);
            if (createdService != null && createdService.Id > 0)
            {
                return true;
            }

            return false;
        }


    }
}
