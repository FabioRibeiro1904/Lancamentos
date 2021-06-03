using Lancamentos.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Lancamentos.Domain.Queries
{
    public static class ProjetoQueries
    {
        public static Expression<Func<Projeto, bool>> GetProjeto(string nome)
        {
            return x => x.NomeProjeto == nome;
        }

        public static Expression<Func<Projeto, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}
