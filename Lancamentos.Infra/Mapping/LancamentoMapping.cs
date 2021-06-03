using Lancamentos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class LancamentoMapping : IEntityTypeConfiguration<Lancamento>
{
    public void Configure(EntityTypeBuilder<Lancamento> builder)
    {
        builder.ToTable("Lancamento");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.DataInicio);
        builder.Property(x => x.DataFim);

    }
}


