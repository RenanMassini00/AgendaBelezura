using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaBelezuza.Infrastructure.Data.Configurations
{
    public class ConfiguracoesProfissionalConfiguration : IEntityTypeConfiguration<ConfiguracoesProfissional>
    {
        public void Configure(EntityTypeBuilder<ConfiguracoesProfissional> builder)
        {
            builder.ToTable("ConfiguracoesProfissional");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.IntervaloSlotsMinutos).IsRequired();
            builder.Property(x => x.AntecedenciaMinimaHoras).IsRequired();
            builder.Property(x => x.CancelamentoMinimoHoras).IsRequired();

            builder.HasOne(x => x.Profissional)
                   .WithOne(x => x.Configuracoes)
                   .HasForeignKey<ConfiguracoesProfissional>(x => x.ProfissionalId);
        }
    }
}
