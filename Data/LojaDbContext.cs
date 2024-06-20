using Microsoft.EntityFrameworkCore;

namespace LojaTrabalhoWeb.Data
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext(DbContextOptions<LojaDbContext> options) : base(options) { }
        public DbSet<ProducesResponseTypeMetadata> Produto { get; set; }
    }
}
