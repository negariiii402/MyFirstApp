public class DbContext : DbContext{
    public class DbContext(DbContextOption option)
        :base()
    {
        
    }
    public DbSet<Book> Books{get; set;}
    public DbSet<Factor> Factories{get; set;}
    public DbSet<FactorItem> FactorItems{get; set;}
    public DbSet<Customer> Customers{get; set;}
    public DbSet<Chashier> Cashiers{get; set;}
}