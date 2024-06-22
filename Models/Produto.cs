namespace LojaTrabalhoWeb.Models
{
    public class Produto
    {
        private int idProduto;
        private string nomeProduto;

        public Produto(int idProduto, string nomeProduto)
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Fornecedor { get; set; }
        public int Quantidade { get; internal set; }
    }
}
