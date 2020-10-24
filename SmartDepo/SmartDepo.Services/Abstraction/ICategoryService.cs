using SmartDepo.Services.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartDepo.Services.Abstraction
{
    public interface ICategoryService
    {
        Task<CategoryDTO> InsertCategory(CategoryDTO categoryDTO);
        Task<CategoryDTO> UpdateCategory(CategoryDTO categoryDTO);
        void DeleteCategory(Guid categoryId);
        Task<IEnumerable<CategoryDTO>> GetAll();
        Task<CategoryDTO> GetCategoryById(Guid categoryId);
    }
}
