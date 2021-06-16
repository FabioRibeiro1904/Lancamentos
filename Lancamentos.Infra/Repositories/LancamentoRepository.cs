using Lancamentos.Domain.Entities;
using Lancamentos.Domain.Queries;
using Lancamentos.Domain.Repository;
using Lancamentos.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
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

        public Desenvolvedor GetDev(Guid id)
        {
           
            
            return _context.Desenvolvedores.FirstOrDefault(DesenvolvedorQueries.GetId(id));
        }

        public IEnumerable<Desenvolvedor> GetList()
        {

            var lancamentos = _context.Lancamentos.Include(x=>x.Desenvolvedor).ToList();
            var res = from totals in
                                    (from total in lancamentos
                                     group total by total.Desenvolvedor into Devs
                                     select new { todasAsHoras = Devs.Sum(x => (x.DataInicio - x.DataFim).TotalHours), dev = Devs.Key })
                      orderby totals.todasAsHoras descending
                      select totals.dev;


            return res;     
        }

    }
}
