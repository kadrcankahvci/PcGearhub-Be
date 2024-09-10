using PcGearHub.Data.DBModels;
using Microsoft.EntityFrameworkCore;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Implements
{
    public class UserRepository:BaseRepository<User>, IUserRepository    {
        public UserRepository(DemodbContext context) : base(context)
        {
            
        }
        public async Task<User> GetUserWithAllDetail(int id)
        {
           var user  =  await _dbSet
                .Include(x => x.Addresses)
                .Include(x => x.Orders)
                .FirstOrDefaultAsync(x=> x.UserId == id);

            return user;               
        }

     

        //public async Task<User> GetById(int id)
        //{
        //    return await (await base.GetById(id)).Include(user => user.Orders) // Kullanıcının siparişlerini dahil et
        //        .Include(user => user.Addresses) // Kullanıcının adresini dahil et
        //        .Where(user => user.UserId == id).FirstOrDefaultAsync(); // Belirtilen userId'ye göre filtrele
        //}

    }
}
