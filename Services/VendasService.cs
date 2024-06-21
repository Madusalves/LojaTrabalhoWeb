using LojaTrabalhoWeb.Data;
using Microsoft.EntityFrameworkCore;
using static LojaTrabalhoWeb.Models.VendasModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using LojaTrabalhoWeb.Models;
using System;




namespace LojaTrabalhoWeb.Services
{
    public class VendasService
    {
        private readonly List<Venda> _vendas;

        public VendasService()
        {
            _vendas = new List<Venda>();
        }

        public void AdicionarVenda(Venda venda)
        {
            _vendas.Add(venda);
        }

        public List<Venda> ObterVendas()
        {
            return _vendas;
        }

        public Venda ObterVendaPorId(int id)
        {
            return _vendas.Find(v => v.Id == id);
        }

        public void AtualizarVenda(Venda venda)
        {
            var vendaExistente = ObterVendaPorId(venda.Id);
            if (vendaExistente != null)
            {
                vendaExistente.DataVenda = venda.DataVenda;
                vendaExistente.NumeroNotaFiscal = venda.NumeroNotaFiscal;
                vendaExistente.IdCliente = venda.IdCliente;
                vendaExistente.Cliente = venda.Cliente;
                vendaExistente.IdProduto = venda.IdProduto;
                vendaExistente.Produto = venda.Produto;
                vendaExistente.QuantidadeVendida = venda.QuantidadeVendida;
                vendaExistente.PrecoUnitario = venda.PrecoUnitario;
            }
        }

        public void RemoverVenda(int id)
        {
            _vendas.RemoveAll(v => v.Id == id);
        }
    }

    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string NumeroNotaFiscal { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }

        public int IdProduto { get; set; }
        public string Produto { get; set; }

        public int QuantidadeVendida { get; set; }
        public decimal PrecoUnitario { get; set; }
    }

}
}
