using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDepo.Entities.Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product> Products { get; }
    }
}
