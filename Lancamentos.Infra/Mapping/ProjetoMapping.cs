using Lancamentos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProjetoMapping : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
        builder.HasKey(x => x.Id);
            builder.ToTable("Projeto");
            builder.Property(x => x.NomeProjeto).HasMaxLength(30).HasColumnType("varchar(30)");
            builder.Property(x => x.Tipo).HasMaxLength(30).HasColumnType("varchar(30)");

        }
    }


