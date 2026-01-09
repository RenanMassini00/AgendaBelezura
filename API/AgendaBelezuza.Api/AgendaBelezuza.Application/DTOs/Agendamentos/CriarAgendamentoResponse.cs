
namespace AgendaBelezuza.Application.DTOs.Agendamentos
{
    public class CriarAgendamentoResponse
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Status { get; set; } = null!;
    }
}
