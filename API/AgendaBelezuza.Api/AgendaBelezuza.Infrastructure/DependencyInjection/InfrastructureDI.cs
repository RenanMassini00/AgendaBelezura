using AgendaBelezuza.Application.Interfaces.Repositories;
using AgendaBelezuza.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaBelezuza.Infrastructure.DependencyInjection
{
    public static class InfrastructureDI
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IProfissionalRepository, ProfissionalRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();
            services.AddScoped<IHorarioFuncionamentoRepository, HorarioFuncionamentoRepository>();
            services.AddScoped<IBloqueioAgendaRepository, BloqueioAgendaRepository>();
            services.AddScoped<IConfiguracoesProfissionalRepository, ConfiguracoesProfissionalRepository>();

            return services;
        }
    }
}
