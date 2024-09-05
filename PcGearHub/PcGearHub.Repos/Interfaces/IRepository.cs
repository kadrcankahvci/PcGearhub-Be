using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        Task<IQueryable<T>> GetById(int id);              // GetById
        Task<List<T>> GetAll();                // GetAll
        Task Create(T entity);                // Create
        Task Update(T entity);                // Update
        Task Delete(int id );                // Delete
    }
}
