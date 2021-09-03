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
                new Product() { Id = 1, Description = "Drone", Code = 123, Amount = 1 },
                new Product() { Id = 11, Description = "Copo", Code = (long)456, Amount = 5 },
                new Product() { Id = 12, Description = "Mesa", Code = (long)789, Amount = 0 },
                new Product() { Id = 13, Description = "Cadeira", Code = (long)1011, Amount = 0 },
                new Product() { Id = 14, Description = "Note Book", Code = (long)1213, Amount = 10 },
                new Product() { Id = 15, Description = "Cavalo", Code = (long)1015, Amount = 99 },
                new Product() { Id = 16, Description = "Manjare", Code = (long)1617, Amount = 15 }
            );
        }
    }
}
