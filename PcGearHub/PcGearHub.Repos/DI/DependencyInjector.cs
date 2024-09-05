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
      
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IAddressRespository, AddressRepositry>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ILogHistoryRepository, LogHistoryRespository>();
            services.AddScoped<IOrderRepository,OrderRepository>();
            services.AddScoped<IOrderItemRepository,OrderItemRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IProductReviewRepository, ProductReviewRepository>();
            services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();

            // Diğer servis konfigürasyonları burada yapılabilir
        }
        }
    
    
}
