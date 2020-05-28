using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day5Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace day5Assignment.DBContext
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
