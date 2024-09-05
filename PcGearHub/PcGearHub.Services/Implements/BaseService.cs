using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Implements
{
    public class BaseService<T> : IBaseService<T> where T : class, new()
    {
        protected readonly IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }
        public async Task Create(T entity)
        {
            await _repository.Create(entity);
        }

        public async Task Delete(int id) 
        {
             await _repository.Delete(id);
           
        }

        public async Task<List<T>> GetAll()
        {
                
            return await _repository.GetAll();
        }

        public async Task<T> GetById(int id)
        {
            return (await _repository.GetById(id)).FirstOrDefault();
        }

        public async Task Update(T entity)
        {
            await _repository.Update(entity);
        }
    }
}
