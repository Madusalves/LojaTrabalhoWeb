using System;

namespace LojaTrabalhoWeb.Models
{
    public class FinalizandoVenda
    {
        public int QuantidadeVendida { get; private set; }

        public void FinalizarVenda()
        {
            if (Cliente == null)
            {
                throw new ArgumentNullException("Cliente");
            }

            if (Produto == null)
            {
                throw new ArgumentNullException("Produto");
            }

            if (QuantidadeVendida <= 0)
            {
                throw new ArgumentOutOfRangeException("QuantidadeVendida", "A quantidade vendida deve ser maior que zero.");
            }

            // Verifica se o produto existe no depósito
            var produtoNoDeposito = Deposito.Produtos.Find(p => p.Id == Produto.Id);

            if (produtoNoDeposito == null)
            {
                throw new ArgumentException("Produto não encontrado no depósito.");
            }

            // Verifica se a quantidade vendida é menor ou igual à quantidade em estoque
            if (QuantidadeVendida > produtoNoDeposito.Quantidade)
            {
                throw new ArgumentOutOfRangeException("QuantidadeVendida", "A quantidade vendida não pode ser superior à quantidade em estoque.");
            }

            // Atualiza a quantidade do produto no depósito
            produtoNoDeposito.Quantidade -= QuantidadeVendida;

        }

    }
}
