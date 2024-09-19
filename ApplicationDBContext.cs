using Microsoft.EntityFrameworkCore;

namespace BincomContactSessionAssignment3;
public class ApplicationDBContext : DbContext
{
    public DbSet<Gallery> Galleries { get; set; }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gallery>()
        .HasKey(a => a.Id);
    }

}
