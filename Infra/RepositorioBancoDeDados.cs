using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Sistema_de_Mercado
{
    public class RepositorioBancoDeDados : IRepositorio
    {
        SqlCommand? comando;

        public SqlConnection Conexao()
        {
            SqlConnection? conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSistemaDeMercado"].ConnectionString);
            conexao.Open();
            return conexao;
        }

        public void AtualizarProduto(Produto produto)
        {
            using (var conn = Conexao())
            {
                try
                {
                    comando = new SqlCommand("UPDATE tb_produto SET nome = @nome, marca = @marca, codigo_barras" +
                        " = @codigo_barras, data_vencimento = @data_vencimento, data_cadastro = @data_cadastro WHERE Id = @Id;", conn);

                    comando.Parameters.AddWithValue("@Id", produto.Id);
                    comando.Parameters.AddWithValue("@nome", produto.Nome);
                    comando.Parameters.AddWithValue("@marca", produto.Marca);
                    comando.Parameters.AddWithValue("@codigo_barras", produto.CodigoBarras);
                    comando.Parameters.AddWithValue("@data_vencimento", produto.DataVencimento);
                    comando.Parameters.AddWithValue("@data_cadastro", produto.DataCadastro);

                    comando.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Erro ao atualizar produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DeletarProduto(int Id)
        {
            using (var conn = Conexao())
            {
                try
                {
                    var comando = new SqlCommand("DELETE FROM tb_produto WHERE Id = @Id;", conn);
                    {
                        comando.Parameters.AddWithValue("@id", Id);
                        comando.ExecuteNonQuery();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao deletar produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AdicionarProduto(Produto produto)
        {
            using (var conn = Conexao())
            {
                try
                {
                    comando = new SqlCommand("INSERT INTO tb_produto(nome, marca, codigo_barras, data_vencimento, data_cadastro)" +
                    " values (@nome, @marca, @codigo_barras, @data_vencimento, @data_cadastro);", conn);

                    comando.Parameters.AddWithValue("@nome", produto.Nome);
                    comando.Parameters.AddWithValue("@marca", produto.Marca);
                    comando.Parameters.AddWithValue("@codigo_barras", produto.CodigoBarras);
                    comando.Parameters.AddWithValue("@data_vencimento", produto.DataVencimento);
                    comando.Parameters.AddWithValue("@data_cadastro", produto.DataCadastro);

                    comando.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Erro ao adicionar novo produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Produto ObterPorId(int Id)
        {
            Conversor conversor = new();
            List<Produto> lista = new();

            using (var conn = Conexao())
            {
                try
                {
                    var comando = new SqlCommand("SELECT * FROM tb_produto WHERE Id = @Id;", conn);
                    comando.Parameters.AddWithValue("@Id", Id);

                    DataTable dt = new DataTable();
                    var adapt = new SqlDataAdapter(comando);
                    adapt.Fill(dt);
                    lista = conversor.ConverteProduto(dt);
                }
                catch
                {
                    MessageBox.Show("Erro ao obter produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lista[0];
        }

        public List<Produto> ObterTodos()
        {
            Conversor conversor = new();
            List<Produto> lista = new();

            using (var conn = Conexao())
            {
                try
                {
                    comando = new SqlCommand("SELECT * FROM tb_produto;", conn);

                    var adapt = new SqlDataAdapter(comando);
                    DataTable dt = new();
                    adapt.Fill(dt);
                    lista = conversor.ConverteProduto(dt);
                }
                catch
                {
                    MessageBox.Show("Erro ao obter produtos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lista;
        }
    }
}