using Microsoft.EntityFrameworkCore;
using Lancamentos.Domain.Entities;
using Lancamentos.Infra.Mapping;

namespace Lancamentos.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }


        public DbSet<Lancamento> Lancamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new DesenvolvedorMapping());
            modelBuilder.ApplyConfiguration(new LancamentoMapping());
            modelBuilder.ApplyConfiguration(new ProjetoMapping());
        }
    }
}
