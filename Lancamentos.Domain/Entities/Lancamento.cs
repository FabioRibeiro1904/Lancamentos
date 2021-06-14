using System;

namespace Lancamentos.Domain.Entities
{
    public class Lancamento : Entity
    {
        public Lancamento(DateTime dataInicio, DateTime dataFim)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;

        }

        public DateTime DataInicio { get; private set; }

        public DateTime DataFim { get; private set; }

        public Desenvolvedor Desenvolvedor { get;  private set; }

    }
}
