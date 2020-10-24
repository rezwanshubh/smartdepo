using AutoMapper;
using SmartDepo.Data;
using SmartDepo.Entities.Domain;
using SmartDepo.Services.Abstraction;
using SmartDepo.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartDepo.Services.Catalog
{
    public class CategoryService : ICategoryService
    {
        protected readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(
            IMapper mapper,
            IRepository<Category> categoryRepository
            )
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public void DeleteCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetCategoryById(Guid productId)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryDTO> InsertCategory(CategoryDTO categoryDTO)
        {
            if (categoryDTO == null)
                throw new ArgumentNullException(nameof(categoryDTO));

            //insert            
            await _categoryRepository.Insert(_mapper.Map<CategoryDTO, Category>(categoryDTO));
            return categoryDTO;
        }

        public Task<CategoryDTO> UpdateCategory(CategoryDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
