using LojaTrabalhoWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LojaTrabalhoWeb.Models
{
    public class VendaSumarizada : VendasModel
    {
        public VendaSumarizada(int id, DateTime dataVenda, string notaFiscal, Cliente cliente, Produto produto, int quantidadeVendida, decimal precoUnitario) : base(id, dataVenda, notaFiscal, cliente, produto, quantidadeVendida, precoUnitario)
        {

        }

        public string NomeProduto { get; set; }
        public int QuantidadeTotalVendida { get; set; }
        public decimal ValorTotalVendido { get; set; }
    }

    public static List<VendaSumarizada> ConsultarVendasProdutoSumarizadas(int idProduto)
    {
        var vendasSumarizadas = new List<VendaSumarizada>();

        // Obter as vendas do produto especificado
        IEnumerable<Venda> vendasEncontradas;

        foreach (var venda in vendasEncontradas)
        {
            var vendaSumarizada = vendasSumarizadas.Find(
                vs => vs.NomeProduto == venda.Produto.Nome
            );

            if (vendaSumarizada == null)
            {
                vendaSumarizada = new VendaSumarizada
                {
                    NomeProduto = venda.Produto.Nome,
                    QuantidadeTotalVendida = 0,
                    ValorTotalVendido = 0
                };

                vendasSumarizadas.Add(vendaSumarizada);
            }

            vendaSumarizada.QuantidadeTotalVendida += venda.QuantidadeVendida;
            vendaSumarizada.ValorTotalVendido += venda.ValorTotal; 
        }

        return vendasSumarizadas;
    }
}