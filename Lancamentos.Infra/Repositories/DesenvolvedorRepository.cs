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
    public class DesenvolvedorRepository : IDesenvolvedorRepository
    {
        private readonly DataContext _context;

        public DesenvolvedorRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Desenvolvedor desenvolvedor)
        {
            _context.Desenvolvedores.Add(desenvolvedor);
            _context.SaveChanges();
        }

        public Desenvolvedor GetId(Guid id)
        {
            return _context.Desenvolvedores.Find(id);

            //        return _context.Desenvolvedores.AsNoTracking()
           //.Include(x => x.Projeto)
          //.FirstOrDefault(DesenvolvedorQueries.GetId(id));
        }
        public void Update(Desenvolvedor desenvolvedor)
        {
            _context.Entry(desenvolvedor).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void Delete(Guid id)
        {
            var delDesenvolvedor = _context.Desenvolvedores.Find(id);
            _context.Desenvolvedores.Remove(delDesenvolvedor);
            _context.SaveChanges();
        }

        public IEnumerable<Desenvolvedor> GetList()
        {
            return _context.Desenvolvedores.AsNoTracking()
                .Include(x=>x.Projeto)
                .AsNoTracking()
                .ToList();
        }
    }
}
