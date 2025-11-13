using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Perfil> Perfis => Set<Perfil>();
    public DbSet<UsuarioPerfil> UsuarioPerfis => Set<UsuarioPerfil>();
    public DbSet<Profissional> Profissionais => Set<Profissional>();
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Servico> Servicos => Set<Servico>();
    public DbSet<HorarioFuncionamento> HorariosFuncionamento => Set<HorarioFuncionamento>();
    public DbSet<BloqueioAgenda> BloqueiosAgenda => Set<BloqueioAgenda>();
    public DbSet<Agendamento> Agendamentos => Set<Agendamento>();
    public DbSet<ConfiguracaoProfissional> ConfiguracoesProfissional => Set<ConfiguracaoProfissional>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        base.OnModelCreating(model);

        // USUARIOPERFIS (many-to-many manual)
        model.Entity<UsuarioPerfil>()
            .HasKey(x => new { x.UsuarioId, x.PerfilId });

        model.Entity<UsuarioPerfil>()
            .HasOne(x => x.Usuario)
            .WithMany(x => x.UsuarioPerfis)
            .HasForeignKey(x => x.UsuarioId);

        model.Entity<UsuarioPerfil>()
            .HasOne(x => x.Perfil)
            .WithMany(x => x.UsuarioPerfis)
            .HasForeignKey(x => x.PerfilId);

        // PROFISSIONAL ↔ CONFIGURAÇÃO (1:1)
        model.Entity<Profissional>()
            .HasOne(x => x.Configuracao)
            .WithOne(x => x.Profissional)
            .HasForeignKey<ConfiguracaoProfissional>(x => x.ProfissionalId);

        // PROFISSIONAL ↔ SERVIÇOS (1:N)
        model.Entity<Profissional>()
            .HasMany(x => x.Servicos)
            .WithOne(x => x.Profissional)
            .HasForeignKey(x => x.ProfissionalId);

        // PROFISSIONAL ↔ HORARIO FUNCIONAMENTO
        model.Entity<Profissional>()
            .HasMany(x => x.HorariosFuncionamento)
            .WithOne(x => x.Profissional)
            .HasForeignKey(x => x.ProfissionalId);

        // PROFISSIONAL ↔ BLOQUEIOS
        model.Entity<Profissional>()
            .HasMany(x => x.BloqueiosAgenda)
            .WithOne(x => x.Profissional)
            .HasForeignKey(x => x.ProfissionalId);

        // PROFISSIONAL ↔ AGENDAMENTOS
        model.Entity<Profissional>()
            .HasMany(x => x.Agendamentos)
            .WithOne(x => x.Profissional)
            .HasForeignKey(x => x.ProfissionalId);

        // CLIENTE ↔ AGENDAMENTOS
        model.Entity<Cliente>()
            .HasMany(x => x.Agendamentos)
            .WithOne(x => x.Cliente)
            .HasForeignKey(x => x.ClienteId);

        // SERVICO ↔ AGENDAMENTOS
        model.Entity<Servico>()
            .HasMany(x => x.Agendamentos)
            .WithOne(x => x.Servico)
            .HasForeignKey(x => x.ServicoId);

        // TABELAS COM CHECKS (implementados manualmente)
        model.Entity<HorarioFuncionamento>()
            .Property(x => x.DiaSemana)
            .HasConversion<byte>();

        model.Entity<Agendamento>()
            .Property(x => x.Status)
            .HasMaxLength(20);
    }
}
