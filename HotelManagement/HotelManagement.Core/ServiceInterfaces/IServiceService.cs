using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Core.Entities;

namespace HotelManagement.Core.ServiceInterfaces
{
    public interface IServiceService
    {
        Task<List<Service>> GetAllServices();
    }
}
