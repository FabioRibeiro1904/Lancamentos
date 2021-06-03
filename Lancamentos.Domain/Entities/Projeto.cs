using System.Collections.Generic;

namespace Lancamentos.Domain.Entities
{
    public class Projeto : Entity
    {
        private List<Desenvolvedor> _desenvolvedor;

        public Projeto(string nomeProjeto, string tipo)
        {
            _desenvolvedor = new List<Desenvolvedor>();
            NomeProjeto = nomeProjeto;
            Tipo = tipo;
        }
        public string NomeProjeto { get; private set; }

        public string Tipo { get; private set; }

        //public IReadOnlyCollection<Desenvolvedor> Desenvolvedors { get { return _desenvolvedor.ToArray(); } }

        public IList<Desenvolvedor> Desenvolvedors { get; private set; }


        public void UpdateTitle(string nome, string tipo)
        {
            NomeProjeto = nome;
            Tipo = tipo;
        }

        public void AddDesenvolvedor(Desenvolvedor desenvolvedor)
        {
            _desenvolvedor.Add(desenvolvedor);
        }
    }
}
