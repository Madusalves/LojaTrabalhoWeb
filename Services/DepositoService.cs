using LojaTrabalhoWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace LojaTrabalhoWeb.Services
{
    public class DepositoService
    {
        private readonly Deposito deposito;

        public DepositoService(Deposito deposito)
        {
            this.deposito = deposito;
        }

        public void AdicionarProduto(int idProduto, string nomeProduto, int quantidade)
        {
            var produto = new Produto(idProduto, nomeProduto);
            deposito.AdicionarProduto(produto, quantidade);
        }

        public List<Produto> ObterProdutos()
        {
            return deposito.Produtos;
        }

        public Produto ObterProdutoPorId(int idProduto)
        {
            return deposito.Produtos.FirstOrDefault(p => p.Id == idProduto);
        }
    }
}
