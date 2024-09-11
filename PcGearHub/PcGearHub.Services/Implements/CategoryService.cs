using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Implements;
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
    internal class CategoryService : BaseService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository repository) : base(repository)
        {
            _categoryRepository = repository;
        }

        public async Task<Category> CreateCategory(CategoryDTO categoryDTO)
        {
            if (categoryDTO == null)
            {
                throw new ArgumentNullException(nameof(categoryDTO));
            }

            // DTO'dan Entity'ye dönüştürme
            var category = new Category
            {
                Name = categoryDTO.Name,
                Description = categoryDTO.Description,
            };

            // Veritabanına ekleme
            await _categoryRepository.Create(category);

            return category; // Oluşturulan kategoriyi döndür
        }
    }
}
