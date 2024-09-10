using PcGearHub.Data.DBModels;

using PcGearHub.Services.DTO;
using System.Collections.Generic;
using System.Linq;

namespace PcGearHub.Services.ConvertDTO
{
    public static class Mapper
    {
        // User to UserDTO
        public static UserDTO ToUserDTO(User user)
        {
            return new UserDTO
            {    
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                       
            };
        }
     

        // Address to AddressDTO
        public static AddressDTO ToAddressDTO(Address address)
        {
            return new AddressDTO
            {
                AddressId = address.AddressId,
               
                Street = address.Street,
                City = address.City,
                State = address.State,
              
            };
        }

        // Order to OrderDTO
        public static OrderDTO ToOrderDTO(Order order)
        {
            return new OrderDTO
            {
               OrderId = order.OrderId,
                 TotalAmount = order.TotalAmount,
                OrderStatus = order.Status
            };
        }
        public static ProductDTO ToProductDTO(Product product) {
            return    new ProductDTO
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                CategoryId = product.CategoryId ?? 0,
            };
        }

    }
}
