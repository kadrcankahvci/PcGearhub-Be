using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.DI;
using PcGearHub.Repos.Implements;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PcGearHub.Services.DI
{
    public static class ServiceDI
    {
        
        
 public static void Init(IServiceCollection services)
            {
            // DbContext konfigürasyonu

            // Service konfigürasyonu

            //services.AddScoped<IProductService,ProductSe>();
            //services.AddScoped<IProductRepository,ProductRepository>();
            //services.AddScoped<IProductRepository,ProductRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();
            ReposDI.Init(services);

            // Diğer servis konfigürasyonları burada yapılabilir
        }
        }
    
    
}
