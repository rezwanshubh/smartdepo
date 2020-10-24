using SmartDepo.Services.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartDepo.Services.Abstraction
{
    public interface IProductService
    {
        Task<ProductDTO> InsertProduct(ProductDTO product);
        Task<ProductDTO> UpdateProduct(ProductDTO product);
        void DeleteProduct(Guid productId);
        Task<IEnumerable<ProductDTO>> GetAll();
        Task<ProductDTO> GetProductById(Guid productId);
    }
}
