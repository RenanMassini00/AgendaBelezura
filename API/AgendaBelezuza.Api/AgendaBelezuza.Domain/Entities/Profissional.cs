using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Domain.Entities
{
    public class Profissional
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        public string NomePublico { get; private set; } = null!;
        public string? Telefone { get; private set; }
        public string? Documento { get; private set; }
        public string? Descricao { get; private set; }

        public bool Ativo { get; private set; }
        public DateTime CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        public ICollection<Servico> Servicos { get; private set; } = new List<Servico>();
        public ICollection<HorarioFuncionamento> HorariosFuncionamento { get; private set; } = new List<HorarioFuncionamento>();
        public ConfiguracoesProfissional? Configuracoes { get; private set; }
        public ICollection<BloqueioAgenda> Bloqueios { get; private set; } = new List<BloqueioAgenda>();
        public ICollection<Agendamento> Agendamentos { get; private set; } = new List<Agendamento>();

        protected Profissional() { }

        public Profissional(int usuarioId, string nomePublico)
        {
            if (usuarioId <= 0)
                throw new DomainException("Usuário inválido.");

            UsuarioId = usuarioId;
            NomePublico = nomePublico;
            Ativo = true;
            CriadoEm = DateTime.UtcNow;
        }

        public void Atualizar(string nomePublico, string? telefone, string? documento, string? descricao)
        {
            NomePublico = nomePublico;
            Telefone = telefone;
            Documento = documento;
            Descricao = descricao;
            AtualizadoEm = DateTime.UtcNow;
        }

        public void Desativar()
        {
            Ativo = false;
            AtualizadoEm = DateTime.UtcNow;
        }
    }
}