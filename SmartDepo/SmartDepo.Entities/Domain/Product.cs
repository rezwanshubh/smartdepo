using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDepo.Entities.Domain
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Int64 Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsPublished { get; set; }
        public Guid CategoryId { get; set; }
    }
}
