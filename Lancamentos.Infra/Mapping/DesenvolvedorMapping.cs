using Lancamentos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lancamentos.Infra.Mapping
{
    public class DesenvolvedorMapping : IEntityTypeConfiguration<Desenvolvedor>
    {
        public void Configure(EntityTypeBuilder<Desenvolvedor> builder)
        {

            builder.HasKey(x => x.Id);
            builder.ToTable("Desenvolvedor");

            builder.Property(x => x.Nome)
                .HasMaxLength(60)
                .HasColumnType("varchar(60)");

            builder.Property(x => x.Cargo)
                .HasMaxLength(60)
                .HasColumnType("varchar(60)");

            builder.HasOne(x => x.Projeto)
                 .WithMany(x => x.Desenvolvedors)
                 .HasPrincipalKey(x => x.Id)
                 .HasForeignKey(x=>x.ProjetoId);

            builder.HasMany(x => x.Lancamentos)
                .WithOne(x => x.Desenvolvedor);
                
        }
    }
}
