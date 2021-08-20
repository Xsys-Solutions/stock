using Entities.Stock;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Data
{
    public class RepositoryEFContext : DbContext
    {
        public RepositoryEFContext(DbContextOptions<RepositoryEFContext> options) : base(options) { }
        public virtual DbSet<Product> Products { get; set; }
    }
}
