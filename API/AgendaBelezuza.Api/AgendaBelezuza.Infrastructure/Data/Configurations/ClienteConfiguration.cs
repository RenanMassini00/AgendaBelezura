using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaBelezuza.Infrastructure.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(150);

            builder.Property(x => x.Telefone)
                .HasMaxLength(20);

            builder.Property(x => x.Documento)
                .HasMaxLength(20);

            builder.Property(x => x.Ativo)
                .IsRequired();
        }
    }
}
