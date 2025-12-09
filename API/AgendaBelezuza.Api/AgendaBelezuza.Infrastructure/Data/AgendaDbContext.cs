using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AgendaBelezuza.Infrastructure.Data
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Perfil> Perfis => Set<Perfil>();
        public DbSet<UsuarioPerfil> UsuarioPerfis => Set<UsuarioPerfil>();

        public DbSet<Profissional> Profissionais => Set<Profissional>();
        public DbSet<Servico> Servicos => Set<Servico>();
        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Agendamento> Agendamentos => Set<Agendamento>();
        public DbSet<HorarioFuncionamento> HorariosFuncionamento => Set<HorarioFuncionamento>();
        public DbSet<BloqueioAgenda> BloqueiosAgenda => Set<BloqueioAgenda>();
        public DbSet<ConfiguracoesProfissional> ConfiguracoesProfissional => Set<ConfiguracoesProfissional>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica automaticamente todas as classes de mapeamento da pasta Configurations
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
