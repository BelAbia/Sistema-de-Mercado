using LinqToDB;
using LinqToDB.DataProvider.SqlServer;
using System.Configuration;

namespace Sistema_de_Mercado
{
    public class RepositorioLinq2Db : IRepositorio
    {
        public static string Conexao()
        {
            return ConfigurationManager.ConnectionStrings["ConexaoSistemaDeMercado"].ConnectionString;
        }
        public void AdicionarProduto(Produto produto)
        {
            using (var conexaoLinq2Db = SqlServerTools.CreateDataConnection(Conexao()))
            {
                try
                {
                    conexaoLinq2Db.Insert(produto);
                }
                catch
                {
                    throw new Exception("Erro ao adicionar novo produto.");
                }
            }
        }

        public void AtualizarProduto(Produto produto)
        {
            using (var conexaoLinq2Db = SqlServerTools.CreateDataConnection(Conexao()))

            {
                try
                {
                    conexaoLinq2Db.Update(produto);
                }
                catch
                {
                    throw new Exception("Erro ao atualizar produto.");
                }
            }
        }

        public void DeletarProduto(int LinhaSelecionada)
        {
            using (var conexaoLinq2Db = SqlServerTools.CreateDataConnection(Conexao()))

            {
                try
                {
                    var produtoEscolhido = ObterPorId(LinhaSelecionada);
                    conexaoLinq2Db.Delete(produtoEscolhido);
                }
                catch
                {
                    throw new Exception("Erro ao deletar produto.");
                }
            }
        }

        public Produto ObterPorId(int Id)
        {
            using (var conexaoLinq2Db = SqlServerTools.CreateDataConnection(Conexao()))

            {

                var produtoEncontrado = conexaoLinq2Db.GetTable<Produto>().FirstOrDefault(X => X.Id == Id)
                     ?? throw new Exception($"Produto não encontrado com id: {Id}");

                return produtoEncontrado;
            }
        }

        public List<Produto> ObterTodos()
        {
            using (var conexaoLinq2DB = SqlServerTools.CreateDataConnection(Conexao()))
            {
                try
                {
                    var query = from p in conexaoLinq2DB.GetTable<Produto>()
                                select p;

                    return query.ToList();
                }
                catch
                {
                    throw new Exception("Erro ao obter produtos.");
                }
            }
        }
    }
}