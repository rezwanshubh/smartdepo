using Microsoft.EntityFrameworkCore;
using SmartDepo.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDepo.Data
{
    public class SmartDepoContext : DbContext
    {
        public SmartDepoContext(DbContextOptions<SmartDepoContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
