using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Domain.Entities
{
    public class Servico
    {
        public int Id { get; private set; }
        public int ProfissionalId { get; private set; }
        public Profissional Profissional { get; private set; }

        public string Nome { get; private set; } = null!;
        public string? Descricao { get; private set; }
        public int DuracaoMinutos { get; private set; }
        public decimal Preco { get; private set; }

        public bool Ativo { get; private set; }
        public DateTime CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        protected Servico() { }

        public Servico(int profissionalId, string nome, int duracao, decimal preco)
        {
            if (profissionalId <= 0)
                throw new DomainException("Profissional inválido.");

            Nome = nome;
            DuracaoMinutos = duracao;
            Preco = preco;

            ProfissionalId = profissionalId;
            Ativo = true;
            CriadoEm = DateTime.UtcNow;
        }

        public void Atualizar(string nome, string? descricao, int duracao, decimal preco)
        {
            Nome = nome;
            Descricao = descricao;
            DuracaoMinutos = duracao;
            Preco = preco;

            AtualizadoEm = DateTime.UtcNow;
        }

        public void Desativar()
        {
            Ativo = false;
            AtualizadoEm = DateTime.UtcNow;
        }
    }
}
