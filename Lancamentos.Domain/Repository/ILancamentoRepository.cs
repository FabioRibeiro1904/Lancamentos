using Lancamentos.Domain.Entities;
using System.Collections.Generic;

namespace Lancamentos.Domain.Repository
{
    public interface ILancamentoRepository
    {
        IEnumerable<Lancamento> GetList();

        void Create(Lancamento lancamento);

    }
}
