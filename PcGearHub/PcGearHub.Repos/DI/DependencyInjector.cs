using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Implements;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PcGearHub.Repos.DI
{
    public static class ReposDI
    {
        
        
 public static void Init(IServiceCollection services)
            {
                // DbContext konfigürasyonu
               
                // Repository konfigürasyonu
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            // Diğer servis konfigürasyonları burada yapılabilir
        }
        }
    
    
}
