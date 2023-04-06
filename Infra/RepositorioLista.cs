using Dominio;

namespace Sistema_de_Mercado
{
    public class RepositorioLista : IRepositorio
    {
        MensagensDeErro mensagensDeErro = new();
        ListaSingleton listaSingleton = ListaSingleton.GetInstance();
        Produto? produtoEncontrado;

        public void AdicionarProduto(Produto produto)
        {
            try
            {
                produto.Id = listaSingleton.ProximoId(produto);
                listaSingleton.ListaProdutos.Add(produto);
                
            }
            catch
            {
                throw new Exception(mensagensDeErro.ErroParaAdicionarProduto);
            }
        }

        public void DeletarProduto(int linhaSelecionada)
        {
            try
            {
                produtoEncontrado = ObterPorId(linhaSelecionada);
                int index = listaSingleton.ListaProdutos.IndexOf(produtoEncontrado);

                listaSingleton.ListaProdutos.RemoveAt(index);
            }
            catch
            {
                throw new Exception(mensagensDeErro.ErroParaDeletarProduto);
            }
        }

        public void AtualizarProduto(Produto produto)
        {
            try
            {
                produtoEncontrado = ObterPorId(produto.Id);
                produtoEncontrado.Nome = produto.Nome;
                produtoEncontrado.Marca = produto.Marca;
                produtoEncontrado.CodigoBarras = produto.CodigoBarras;
                produtoEncontrado.DataVencimento = produto.DataVencimento;
            }
            catch
            {
                throw new Exception(mensagensDeErro.ErroParaAtualizarProduto);
            }
        }

        public Produto ObterPorId(int Id)
        {
            produtoEncontrado = listaSingleton.ListaProdutos.FirstOrDefault(x => x.Id == Id) ??
                throw new Exception(mensagensDeErro.ErroParaObterProdutoPorId(Id));

            return produtoEncontrado;
        }

        public List<Produto> ObterTodos()
        {
            try
            {
                return listaSingleton.ListaProdutos;
            }
            catch
            {
                return null;
                throw new Exception(mensagensDeErro.ErroParaObterListaDeProdutos);
            }
        }
    }
}