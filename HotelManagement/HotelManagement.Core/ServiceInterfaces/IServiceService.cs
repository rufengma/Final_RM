using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;

namespace HotelManagement.Core.ServiceInterfaces
{
    public interface IServiceService
    {
        Task<bool> AddService(AddServiceModel requestService);
        Task<Service> UpdateService(int id, AddServiceModel requestService);
        Task DeleteService(int id);
        Task<Service> SearchService(int id);
    }
}
