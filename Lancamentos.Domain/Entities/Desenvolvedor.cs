using System;
using System.Collections.Generic;
using System.Linq;

namespace Lancamentos.Domain.Entities
{
    public class Desenvolvedor :Entity
    {

        public Desenvolvedor(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
            Lancamentos = new List<Lancamento>();
        }

        public string Nome { get; private set; }

        public string Cargo { get; private set; }

        public Projeto Projeto { get;  private set; }


        public IList<Lancamento> Lancamentos { get; private set; }

        public double WorkHours()
        {
            return Lancamentos.Sum(x => (x.DataInicio - x.DataFim).TotalHours);
        }

        public void UpdateDesenvolvedor(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public void addLancamento(Lancamento lancameto)
        {
            Lancamentos.Add(lancameto);
        }

        public void AddProjeto(Projeto projeto)
        {
            Projeto = projeto;
        }
    }
}
