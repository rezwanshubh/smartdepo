using System;

namespace SmartDepo.Services.DTO
{
    public class ProductDTO : BaseDTO
    {
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public Int64 Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsPublished { get; set; }
        public Guid CategoryId { get; set; }
    }
}
