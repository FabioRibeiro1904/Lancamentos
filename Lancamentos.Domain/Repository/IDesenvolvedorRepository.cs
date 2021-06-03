 
using Lancamentos.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Lancamentos.Domain.Repository
{
    public interface IDesenvolvedorRepository
    {
        IEnumerable<Lancamento> WorkHours(Guid id);

        IEnumerable<Desenvolvedor> GetList();

        void Create(Desenvolvedor desenvolvedor);

        Desenvolvedor GetByName(Guid id, string nome);

        Desenvolvedor GetId(Guid id);

        void Update(Desenvolvedor desenvolvedor);

        void addLancamento(Lancamento desenvolvedor);

        void Delete(Guid id);
    }
}
