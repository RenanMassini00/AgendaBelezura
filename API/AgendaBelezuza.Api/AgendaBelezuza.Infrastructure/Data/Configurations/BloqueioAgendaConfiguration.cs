using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Infrastructure.Data.Configurations
{

    public class BloqueioAgendaConfiguration : IEntityTypeConfiguration<BloqueioAgenda>
    {
        public void Configure(EntityTypeBuilder<BloqueioAgenda> builder)
        {
            builder.ToTable("BloqueiosAgenda");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Motivo)
                .HasMaxLength(250);

            builder.HasOne(x => x.Profissional)
                   .WithMany(x => x.Bloqueios)
                   .HasForeignKey(x => x.ProfissionalId);
        }
    }
}
