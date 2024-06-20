using MySqlConnector;

namespace LojaTrabalhoWeb.Models
{
    public class Fornecedor
    {
        // Atributos da classe Fornecedor
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Fornecedor(int id, string cnpj, string nome, string endereco, string email, string telefone)
        {
            Id = id;
            Cnpj = cnpj;
            Nome = nome;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
        }


        public static void InserirFornecedor(Fornecedor fornecedor, string connectionString)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string sql = "INSERT INTO Fornecedores (Cnpj, Nome, Endereco, Email, Telefone) VALUES (@cnpj, @nome, @endereco, @email, @telefone)";

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                    comando.Parameters.AddWithValue("@nome", fornecedor.Nome);
                    comando.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                    comando.Parameters.AddWithValue("@email", fornecedor.Email);
                    comando.Parameters.AddWithValue("@telefone", fornecedor.Telefone);

                    comando.ExecuteNonQuery();
                }
            }
        }


        public static void AtualizarFornecedor(Fornecedor fornecedor, string connectionString)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();


                string sql = "UPDATE Fornecedores SET Cnpj = @cnpj, Nome = @nome, Endereco = @endereco, Email = @email, Telefone = @telefone WHERE Id = @id";


                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", fornecedor.Id);
                    comando.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                    comando.Parameters.AddWithValue("@nome", fornecedor.Nome);
                    comando.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                    comando.Parameters.AddWithValue("@email", fornecedor.Email);
                    comando.Parameters.AddWithValue("@telefone", fornecedor.Telefone);


                    comando.ExecuteNonQuery();
                }
            }
        }

        public static string GetConnectionString(string connectionString)
        {
            return connectionString;
        }

        public static void ExcluirFornecedor(int idFornecedor, string connectionString)
        {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string sql = "DELETE FROM Fornecedores WHERE Id = @id";


                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", idFornecedor);
                }


            }
        }
    }
}
