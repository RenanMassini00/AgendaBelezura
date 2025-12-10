using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaBelezuza.Infrastructure.Data.Configurations
{
    public class ServicoConfiguration : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servicos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasMaxLength(500);

            builder.Property(x => x.DuracaoMinutos)
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.HasOne(x => x.Profissional)
                   .WithMany(x => x.Servicos)
                   .HasForeignKey(x => x.ProfissionalId);
        }
    }
}
