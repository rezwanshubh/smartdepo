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
    public class ProductService : IProductService
    {
        protected readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;
        public ProductService(
            IMapper mapper,
            IRepository<Product> productRepository
            )
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public void DeleteProduct(Guid productId)
        {
            _productRepository.Delete(productId);
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var productList = _productRepository.GetAll();
            return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>(await productList);
        }

        public async Task<ProductDTO> GetProductById(Guid productId)
        {
            if (productId == null)
                return null;

            Product product = await _productRepository.GetById(productId);

            return _mapper.Map<ProductDTO>(product);

        }

        public async Task<ProductDTO> InsertProduct(ProductDTO productDTO)
        {
            if (productDTO == null)
                throw new ArgumentNullException(nameof(productDTO));

            //insert            
            await _productRepository.Insert(_mapper.Map<ProductDTO, Product>(productDTO));
            return productDTO;
        }

        public async Task<ProductDTO> UpdateProduct(ProductDTO productDTO)
        {
            if (productDTO == null)
                throw new ArgumentNullException(nameof(productDTO));

            //update
            await _productRepository.Update(_mapper.Map<ProductDTO, Product>(productDTO));
            return productDTO;
        }
    }
}
