
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

    public DbSet<LinkInfo> LinkInfos { get; set; }

    public DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      modelBuilder
        .Entity<Message>()
        .HasOne(p => p.LinkInfo)
        .WithMany(p => p.Messages)
        .HasForeignKey(p => p.LinkId);
    }

  }
}