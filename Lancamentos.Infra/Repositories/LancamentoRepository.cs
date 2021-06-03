using Lancamentos.Domain.Entities;
using Lancamentos.Domain.Repository;
using Lancamentos.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lancamentos.Infra.Repositories
{
    public class LancamentoRepository : ILancamentoRepository
    {
        private readonly DataContext _context;

        public LancamentoRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Lancamento lancamento)
        {
            _context.Lancamentos.Add(lancamento);
            _context.SaveChanges();
        }

        public IEnumerable<Lancamento> GetList()
        {
            return _context.Lancamentos.AsNoTracking().ToList();
        }

        //public Lancamento GetByName(string nome)
        //{
        //    return _context.Desenvolvedores.AsNoTracking().FirstOrDefault(LancamentoQueries.GetDesenvolvedor(nome));
        //}
    }
}
