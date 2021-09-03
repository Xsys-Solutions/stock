using Entities.Stock;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Repositories.Data
{
    public class RepositoryEFContext : DbContext
    {
        public RepositoryEFContext(DbContextOptions<RepositoryEFContext> options) : base(options) { }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new { Id = 5, Description = "Danone", Code = 123, Amount = 1 }
            );
        }

    }
}
