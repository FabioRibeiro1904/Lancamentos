 
using Lancamentos.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Lancamentos.Domain.Repository
{
    public interface IDesenvolvedorRepository
    {
        IEnumerable<Desenvolvedor> GetList();

        void Create(Desenvolvedor desenvolvedor);

        Desenvolvedor GetId(Guid id);

        void Update(Desenvolvedor desenvolvedor);

        void Delete(Guid id);
    }
}
