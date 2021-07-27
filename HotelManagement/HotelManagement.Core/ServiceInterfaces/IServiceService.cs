using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;

namespace HotelManagement.Core.ServiceInterfaces
{
    public interface IServiceService
    {
        Task<List<Service>> GetAllServices();
        Task<bool> AddService(AddServiceModel requestService);
    }
}
