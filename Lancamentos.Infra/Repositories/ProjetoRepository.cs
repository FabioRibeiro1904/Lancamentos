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
    public class ProjetoRepository : IProjetoRepository
    {

        private readonly DataContext _context;

        public ProjetoRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Projeto project)
        {
            _context.Projetos.Add(project);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var delProject = _context.Projetos.Find(id);
            _context.Projetos.Remove(delProject);
            _context.SaveChanges();
        }

        public Projeto GetId(Guid id)
        {
            return _context.Projetos.Find(id);
        }

        public IEnumerable<Projeto> GetList()
        {
            return _context.Projetos.AsNoTracking().ToList();
        }

        public void Update(Projeto project)
        {
            _context.Entry(project).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
