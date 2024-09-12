using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.DI;
using PcGearHub.Repos.Implements;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.Implements;
using PcGearHub.Services.Interfaces;
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
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ILogHistoryService, LogHistoryService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderItemService, OrderItemService>();
            services.AddScoped<IPaymentMethodService, PaymentMethodService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IProductReviewService, ProductReviewService>();
            services.AddScoped<IRolePermissionService, RolePermissionService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserRoleService, UserRoleService>();

            ReposDI.Init(services);
        
        }
    }


}
