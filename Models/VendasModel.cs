using System.Collections.Generic;
using System;

namespace LojaTrabalhoWeb.Models
{
    public class VendasModel
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
