namespace Core.Entities;

public class HorarioFuncionamento
{
    public int Id { get; set; }
    public int ProfissionalId { get; set; }
    public Profissional Profissional { get; set; } = null!;

    public byte DiaSemana { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFim { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public DateTime? AtualizadoEm { get; set; }
}
