using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Interfaces
{
    public interface IBaseService<T> where T : class, new()
    {

        Task<T> GetById(int Id);                 // GetById       
        Task<List<T>> GetAll();                // GetAll
        Task Create(T entity);                // Create
        Task Update(T entity);                // Update
        Task Delete(int entity);

     
    }
}
/*
 public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
       {

           IQueryable<T> queryable = GetAll();
           foreach (Expression<Func<T, object>> includeProperty in includeProperties)
           {
               queryable = queryable.Include<T, object>(includeProperty);
           }

           return queryable;
       }

 */