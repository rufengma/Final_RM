using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;
using HotelManagement.Core.Models;
namespace HotelManagement.Core.RepositoryInterfaces
{
    public interface IServiceRepository : IAsyncRepository<Service>
    {
        Task<Service> UpdateService(int id, AddServiceModel model);
    }
}
