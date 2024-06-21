﻿namespace LojaTrabalhoWeb.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Fornecedor { get; set; }
        public int Quantidade { get; internal set; }
    }
}
