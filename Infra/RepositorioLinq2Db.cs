using Dominio;
using LinqToDB;
using LinqToDB.DataProvider.SqlServer;
using System.Configuration;

namespace Sistema_de_Mercado
{
    public class RepositorioLinq2Db : IRepositorio
    {
        MensagensDeErro mensagensDeErro = new();

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
                    var id = conexaoLinq2Db.InsertWithInt32Identity(produto);
                    produto.Id = id;
                }
                catch
                {
                    throw new Exception(mensagensDeErro.ErroParaAdicionarProduto);
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
                    throw new Exception(mensagensDeErro.ErroParaAtualizarProduto);
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
                    throw new Exception(mensagensDeErro.ErroParaDeletarProduto);
                }
            }
        }

        public Produto ObterPorId(int Id)
        {
            using (var conexaoLinq2Db = SqlServerTools.CreateDataConnection(Conexao()))

            {

                var produtoEncontrado = conexaoLinq2Db.GetTable<Produto>().FirstOrDefault(X => X.Id == Id)
                     ?? throw new Exception(mensagensDeErro.ErroParaObterProdutoPorId(Id));

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
                    throw new Exception(mensagensDeErro.ErroParaObterListaDeProdutos);
                }
            }
        }
    }
}