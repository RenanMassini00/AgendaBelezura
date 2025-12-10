using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaBelezuza.Infrastructure.Data.Configurations
{
    public class UsuarioPerfilConfiguration : IEntityTypeConfiguration<UsuarioPerfil>
    {
        public void Configure(EntityTypeBuilder<UsuarioPerfil> builder)
        {
            builder.ToTable("UsuarioPerfis");

            builder.HasKey(x => new { x.UsuarioId, x.PerfilId });

            builder.HasOne(x => x.Usuario)
                   .WithMany(x => x.Perfis)
                   .HasForeignKey(x => x.UsuarioId);

            builder.HasOne(x => x.Perfil)
                   .WithMany()
                   .HasForeignKey(x => x.PerfilId);
        }
    }
}
