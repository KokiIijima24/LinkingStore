
using LinkingStore.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkingStore.GraphQL.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Link> Links { get; set; }

    public DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      modelBuilder
        .Entity<Message>()
        .HasOne(p => p.Link)
        .WithMany(p => p.Messages)
        .HasForeignKey(p => p.LinkId);
    }

  }
}