using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaBelezuza.Infrastructure.Data.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.SenhaHash)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Ativo)
                .IsRequired();

            builder.Property(x => x.CriadoEm)
                .IsRequired();
        }
    }
}
