using System.Collections.Generic;
using System;

namespace LojaTrabalhoWeb.Models
{
    public class VendasModel
    {
        public class Deposit
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public virtual ICollection<DepositProduct> ProdutosDeposito { get; set; } 
        }

        public class DepositProduct
        {
            public int IdDeposito { get; set; }
            public Deposit Deposito { get; set; }

            public int IdProduto { get; set; }
            public Produto Produto { get; set; }

            public int Quantidade { get; set; }
        }


        public class Sale
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
