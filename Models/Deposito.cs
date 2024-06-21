using System;
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
        public void AdicionarProduto(Produto produto, int quantidade)
        {
            if (produto == null)
            {
                throw new ArgumentNullException("produto");
            }

            if (quantidade <= 0)
            {
                throw new ArgumentOutOfRangeException("quantidade", "A quantidade deve ser maior que zero.");
            }

            var produtoExistente = Produtos.Find(p => p.Id == produto.Id);

            if (produtoExistente == null)
            {
                Produtos.Add(produto);
            }

            produtoExistente ??= produto;
            produtoExistente.Quantidade += quantidade;
        }
    }
}
