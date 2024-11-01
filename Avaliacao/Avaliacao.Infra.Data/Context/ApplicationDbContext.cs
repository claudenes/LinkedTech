using Avaliacao.Domain.Entities;
using Avaliacao.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Avaliacao.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Endereco>(new EnderecoMap().Configure);

        }
    }
}
