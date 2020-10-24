using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDepo.Services.DTO
{
    public class CategoryDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ProductDTO> ProductDTOs { get; }
    }
}
