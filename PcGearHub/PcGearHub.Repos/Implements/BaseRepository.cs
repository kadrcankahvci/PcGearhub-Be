using Microsoft.EntityFrameworkCore;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcGearHub.Data;
using System.Linq.Expressions;
using PcGearHub.Data.DBModels;

namespace PcGearHub.Repos.Implements
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); // DbSet<T> otomatik olarak belirlenir
        }

        public async Task Create(T entity)
        {
         /*   var result = */ await _dbSet.AddAsync(entity); 
            await _context.SaveChangesAsync();
            //return result;
        }

        public async Task Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }


        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }


        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public  async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            // Asenkron olarak listeye dönüştürme işlemi
            return await query.ToListAsync();
        }
        public  async Task<IQueryable<T>> GetIncluded(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            // Asenkron olarak listeye dönüştürme işlemi
            return    query;
        }



    }
}