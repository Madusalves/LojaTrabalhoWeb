using System.Collections.Generic;

namespace LojaTrabalhoWeb.Models
{
    public class Deposito
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }

        public Deposito(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Produtos = new List<Produto>();
        }
    }
}
