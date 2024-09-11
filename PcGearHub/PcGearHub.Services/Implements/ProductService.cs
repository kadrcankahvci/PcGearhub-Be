using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.ConvertDTO;
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
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository repository, ICategoryRepository categoryRepository) : base(repository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = repository;
        }

        public async Task<Product> CreateProductFromDto(ProductDTO productDTO)
        {
            // Kategori ID'sine göre Category objesini bul
            var category = await _categoryRepository.GetById(productDTO.CategoryId);

            if (category == null)
            {
                throw new ArgumentException("Invalid Category ID");
            }

            // Product modelini oluştur
            Product product = DTOtoProduct(productDTO, category);

            await _repository.Create(product);

            return product;
        }

        private static Product DTOtoProduct(ProductDTO productDTO, Category category) // static olmayabilir!!
        {
            var product = new Product
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                StockQuantity = productDTO.StockQuantity,
                Image = productDTO.Image,

                Category = category // İlişkilendirilen Category nesnesi
            };

            return product;
        }
        //public async Task<ProductDTO> UpdateProduct (ProductDTO productDTO)
        //{
        //    var product = await GetById(productDTO.ProductId);
        //    if (product is not null)
        //    {

        //        await Update(Mapper.ToProduct(productDTO));
        //         product = await GetById(productDTO.ProductId);
        //        var dto = Mapper.ToProductDTO(product);
        //        return dto;
        //    }
        //    return null;

        //}
        public async Task<ProductDTO> UpdateProduct(ProductDTO productDTO)
        {
            // Ürünü veritabanından alın
            var product = await GetById(productDTO.ProductId);
            if (product == null)
            {
                return null; // Ürün bulunamadı
            }

            // Ürünü güncelleyin
            product.Name = productDTO.Name;
            product.Description = productDTO.Description;
            product.Price = productDTO.Price;
            product.StockQuantity = productDTO.StockQuantity;
            product.CategoryId = productDTO.CategoryId;
            product.Image = productDTO.Image;

            // Değişiklikleri kaydedin
            await Update(product);

            // Güncellenmiş ürünü DTO'ya dönüştürüp döndürün
            var dto = Mapper.ToProductDTO(product);
            return dto;
        }

        public async Task<List<Product>> SearchByQuery(string query)
        {
            var products = await _repository.GetAll();
            return products.Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                                       p.Description.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
