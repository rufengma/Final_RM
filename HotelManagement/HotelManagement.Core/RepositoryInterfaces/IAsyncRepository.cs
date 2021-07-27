using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace HotelManagement.Core.RepositoryInterfaces
{
    public interface IAsyncRepository<T> where T:class
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(int id);
        Task DeleteAsync(int id);
    }
}
