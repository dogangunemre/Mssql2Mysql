using Microsoft.EntityFrameworkCore;
using mssql2Mysql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mssql2Mysql.ProductContext
{
    public class Context:DbContext
    {
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<CategoryDetail> CategoryDetails { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitDetail> UnitDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8Q6K1MA;Database=ProductPoolDB;Trusted_Connection=True;");
        }
    }

}
