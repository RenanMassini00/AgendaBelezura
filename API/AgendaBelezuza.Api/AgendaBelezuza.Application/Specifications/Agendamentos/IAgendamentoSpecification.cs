using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.Specifications.Agendamentos
{
    public interface IAgendamentoSpecification
    {
       Task ValidateAsync(Domain.Entities.Agendamento agendamento);
    }
}
