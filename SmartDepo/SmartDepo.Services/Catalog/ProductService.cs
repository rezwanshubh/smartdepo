using SmartDepo.Services.Abstraction;
using SmartDepo.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartDepo.Services.Catalog
{
    public class ProductService : IProductService
    {
        public void DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetProductById(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> InsertProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> UpdateProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
