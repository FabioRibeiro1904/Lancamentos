using Lancamentos.Domain.Entities;
using System;
using System.Collections.Generic;


namespace Lancamentos.Domain.Repository
{
    public interface ILancamentoRepository
    {
        IEnumerable<Desenvolvedor> GetList();

        void Create(Lancamento lancamento);

        Desenvolvedor GetDev(Guid id);

    }
}
