using Microsoft.EntityFrameworkCore;
using OrderProducts.cs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsOrdersProj.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Asp9_Proj2;Trusted_connection=True;TrustServerCertificate=True");
        }
        public DbSet<Product> Products { get; set; }

    }
}
