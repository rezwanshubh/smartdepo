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
        public void DeleteCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetCategoryById(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> InsertCategory(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> UpdateCategory(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
