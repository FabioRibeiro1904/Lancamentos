using Lancamentos.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Lancamentos.Domain.Queries
{
    public static class LancamentoQueries
    {
        public static Expression<Func<Lancamento, bool>> GetLancamento(Guid nome)
        {
            return x => x.Id == nome;
        }
    }
}
