using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartDepo.Services.Abstraction;
using SmartDepo.Services.DTO;

namespace SmartDepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            return await _productService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ProductDTO> GetById(Guid id)
        {
            return await _productService.GetProductById(id);
        }

        [HttpPost]
        [Route("save")]
        public async Task<ProductDTO> InsertProduct(ProductDTO productDTO)
        {
            return await _productService.InsertProduct(productDTO);
        }

        [HttpPut]
        [Route("update")]
        public async Task<ProductDTO> Update(ProductDTO productDTO)
        {
            return await _productService.UpdateProduct(productDTO);
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(Guid productId)
        {
            _productService.DeleteProduct(productId);
            return Ok();
        }
    }
}