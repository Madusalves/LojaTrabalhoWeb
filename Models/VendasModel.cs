using System.Collections.Generic;
using System;
using LojaTrabalhoWeb.Models;
using LojaTrabalhoWeb.Services;

namespace LojaTrabalhoWeb.Models
{
    public class VendasModel : Deposito
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string NotaFiscal { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeVendida { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal ValorTotal => QuantidadeVendida * PrecoUnitario;

        public VendasModel(
            int id,
            DateTime dataVenda,
            string notaFiscal,
            Cliente cliente,
            Produto produto,
            int quantidadeVendida,
            decimal precoUnitario)
        {
            Id = id;
            DataVenda = dataVenda;
            NotaFiscal = notaFiscal;
            Cliente = cliente;
            Produto = produto;
            QuantidadeVendida = quantidadeVendida;
            PrecoUnitario = precoUnitario;

            ValidarDados();
        }

        private void ValidarDados()
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

            if (PrecoUnitario <= 0)
            {
                throw new ArgumentOutOfRangeException("PrecoUnitario", "O preço unitário deve ser maior que zero.");
            }

            
        }

        public void FinalizarVenda(Deposito deposito)
        {
            ValidarDados();

            // Verifica se o produto existe no depósito
            Produto produtoNoDeposito = deposito.Produtos.Find(p => p.Id == Produto.Id);

            if (produtoNoDeposito == null)
            {
                throw new ArgumentException("Produto não encontrado no depósito.");
            }

            // Verifica se a quantidade vendida é menor ou igual à quantidade em estoque
            if (QuantidadeVendida > produtoNoDeposito.Quantidade)
            {
                throw new ArgumentOutOfRangeException("QuantidadeVendida", "A quantidade vendida não pode ser superior à quantidade em estoque.");
            }

            
            produtoNoDeposito.Quantidade -= QuantidadeVendida;

            GravarVenda(); 
        }

        private void GravarVenda()
        {
            ValidarDados();

            
        }


    }
}
