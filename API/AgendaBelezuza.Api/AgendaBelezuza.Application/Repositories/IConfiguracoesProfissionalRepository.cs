using AgendaBelezuza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.Repositories
{
    public interface IConfiguracoesProfissionalRepository
    {
        Task<ConfiguracoesProfissional?> ObterPorProfissionalIdAsync(int profissionalId);
        Task AdicionarAsync(ConfiguracoesProfissional config);
        Task AtualizarAsync(ConfiguracoesProfissional config);
    }
}
