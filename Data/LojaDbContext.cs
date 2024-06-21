using LojaTrabalhoWeb.Models;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace LojaTrabalhoWeb.Data
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext(DbContextOptions<LojaDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<VendasModel> Vendas { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
    }
}
