using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Implements
{
    public class ProductService : BaseService<Product>,IProductService
    {
        private readonly ICategoryRepository _categoryRepository;
        public ProductService(IProductRepository repository, ICategoryRepository categoryRepository) : base(repository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Product> CreateProductFromDto(ProductDTO productDTO)
        {
            // Kategori ID'sine göre Category objesini bul
            var category = await  _categoryRepository.GetById(productDTO.CategoryId);

            if (category == null)
            {
                throw new ArgumentException("Invalid Category ID");
            }

            // Product modelini oluştur
            var product = new Product
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                StockQuantity = productDTO.StockQuantity,
               
                Category = category // İlişkilendirilen Category nesnesi
            };

            await _repository.Create(product);

            return product;
        }

    }
}
