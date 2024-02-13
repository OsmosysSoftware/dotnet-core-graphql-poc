using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using graphql_demo.Entities;

namespace graphql_demo.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetails>().HasData(
                new ProductDetails
                {
                    Id = Guid.NewGuid(),
                    ProductName = "IPhone",
                    ProductDescription = "IPhone 14",
                    ProductPrice = 120000,
                    ProductStock = 100
                },
                new ProductDetails
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Samsung TV",
                    ProductDescription = "Smart TV",
                    ProductPrice = 400000,
                    ProductStock = 120
                });
        }
    }
}
