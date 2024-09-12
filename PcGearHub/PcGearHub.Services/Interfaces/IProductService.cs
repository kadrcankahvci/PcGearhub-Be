using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Interfaces
{
    public interface IProductService : IBaseService<Product>
    {
        Task<Product> CreateProductFromDto(ProductDTO productDTO);
        Task<ProductDTO> UpdateProduct(ProductDTO productDTO);
        Task<List<Product>> SearchByQuery(string query);
        //Task<IEnumerable<Product>> SearchProduct(string query);
        // tum urunleri degil sadece query deki urunleri getiren method daha verimli bir yontem
    }    
}
