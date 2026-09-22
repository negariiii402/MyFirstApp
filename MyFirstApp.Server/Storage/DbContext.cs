using entity;
using Microsoft.EntityFrameworkCore;
namespace MyFirstApp.Server.Storage
{
public class RepositoryDbContext : DbContext
{
    public  RepositoryDbContext(DbContextOptions option)
        : base(option)
    {
        
    }
    public DbSet<Book> Books{get; set;}

    public DbSet<Factor> Factories{get; set;}

    public DbSet<FactorItem> FactorItems{get; set;}

    public DbSet<Customer> Customers{get; set;}

    public DbSet<Chashier> Cashiers{get; set;}
}
}