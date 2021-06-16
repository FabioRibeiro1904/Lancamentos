using Lancamentos.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Lancamentos.Domain.Queries
{
    public static class DesenvolvedorQueries
    {

        public static Expression<Func<Desenvolvedor, bool>> GetId(Guid Id)
        {
            return x => x.Id == Id;
        }

    }
}
