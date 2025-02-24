using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Artists> Artists { get; set; }

    public DbSet<TestModel> TestModel { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}