using Lancamentos.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Lancamentos.Domain.Repository
{
    public interface IProjetoRepository
    {
        void Create(Projeto project);

        void Update(Projeto project);

        void Delete(Guid id);

        Projeto GetId(Guid id);

        IEnumerable<Projeto> GetList();
    }
}
