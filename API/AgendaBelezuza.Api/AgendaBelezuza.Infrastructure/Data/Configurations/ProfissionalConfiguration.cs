using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaBelezuza.Infrastructure.Data.Configurations
{
    public class ProfissionalConfiguration : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {
            builder.ToTable("Profissionais");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomePublico)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasMaxLength(20);

            builder.Property(x => x.Documento)
                .HasMaxLength(20);

            builder.Property(x => x.Descricao)
                .HasMaxLength(500);

            builder.HasOne(x => x.Usuario)
                   .WithMany()
                   .HasForeignKey(x => x.UsuarioId);
        }
    }
}
