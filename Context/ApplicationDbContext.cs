using Test.Api.Models;

namespace Test.Api.Context;

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<FoodItem> FoodItems { get; set; }
    // public DbSet<Purchase> Purchases { get; set; }
    // public DbSet<PurchaseItem> PurchaseItems { get; set; }
}
