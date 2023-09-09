using EShop.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EShop.API.Context;

public class EShopDbContext : DbContext
{
    public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    public DbSet<ProductCategory> ProductCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        DummyData(modelBuilder);
    }

    private void DummyData(ModelBuilder modelBuilder)
    {
        var productCategoryDummyList = new List<ProductCategory>
        {
            new ProductCategory
            {
                Id = new Guid("f9d09c1f-f7be-4f7c-bf75-b4383934f786"),
                Name = "Fiction",
                CreatedBy = "tam.levan",
                CreatedAt = DateTime.Now.AddDays(-10)
            },
            new ProductCategory
            {
                Id = new Guid("e053fb4e-c731-4982-bc76-9523f60e73a2"),
                Name = "Non-Fiction",
                CreatedBy = "tam.levan",
                CreatedAt = DateTime.Now.AddDays(-9)
            }
        };

        var productList = new List<Product>
        {
            // Fiction Products
            new Product {
                Id = new Guid("1d576eb2-679d-4c5e-9486-1262ea5046cd"),
                CategoryId = productCategoryDummyList.ElementAt(0).Id,
                Name = "Atlas: The Story of Pa Salt",
                CreatedAt = DateTime.Now.AddDays(-8),
                CreatedBy = "tam.levan",
                Stock = 10
            },
            new Product {
                Id = new Guid("73496825-f34f-4c1a-8bbd-400cf212d442"),
                CategoryId = productCategoryDummyList.ElementAt(0).Id,
                Name = "The Seven Sisters books in order: a complete guide",
                CreatedAt = DateTime.Now.AddDays(-8),
                CreatedBy = "tam.levan",
                Stock = 120
            },
            // Non Fiction Products
            new Product {
                Id = new Guid("61d233f9-bcea-446f-8565-f67e4e330881"),
                CategoryId = productCategoryDummyList.ElementAt(1).Id,
                Name = " The Sixth Extinction by Elizabeth Kolbert (2014)",
                CreatedAt = DateTime.Now.AddDays(-8),
                CreatedBy = "tam.levan",
                Stock = 50
            },
            new Product {
                Id = new Guid("5bf20660-dbf9-41d7-9921-1f1ad11aa250"),
                CategoryId = productCategoryDummyList.ElementAt(1).Id,
                Name = "The Year of Magical Thinking by Joan Didion (2005)",
                CreatedAt = DateTime.Now.AddDays(-8),
                CreatedBy = "tam.levan",
                Stock = 30
            },
        };

        modelBuilder.Entity<ProductCategory>().HasData(productCategoryDummyList);
        modelBuilder.Entity<Product>().HasData(productList);
    }
}
