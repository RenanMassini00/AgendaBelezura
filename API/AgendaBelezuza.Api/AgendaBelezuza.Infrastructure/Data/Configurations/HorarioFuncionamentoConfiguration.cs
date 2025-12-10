using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaBelezuza.Infrastructure.Data.Configurations
{
    public class HorarioFuncionamentoConfiguration : IEntityTypeConfiguration<HorarioFuncionamento>
    {
        public void Configure(EntityTypeBuilder<HorarioFuncionamento> builder)
        {
            builder.ToTable("HorariosFuncionamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DiaSemana).IsRequired();
            builder.Property(x => x.HoraInicio).IsRequired();
            builder.Property(x => x.HoraFim).IsRequired();

            builder.HasOne(x => x.Profissional)
                   .WithMany(x => x.HorariosFuncionamento)
                   .HasForeignKey(x => x.ProfissionalId);
        }
    }
}
