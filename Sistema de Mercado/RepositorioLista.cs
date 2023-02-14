namespace Sistema_de_Mercado
{
    public class RepositorioLista : IRepositorio
    {
        ListaSingleton listaSingleton = ListaSingleton.GetInstance();
        Produto? produtoEncontrado;

        public void AdicionarProduto(Produto produto)
        {
            listaSingleton.ListaProdutos.Add(produto);
        }

        public void DeletarProduto(int linhaSelecionada)
        {
            listaSingleton.ListaProdutos.RemoveAt(linhaSelecionada);
        }

        public void AtualizarProduto(Produto produto)
        {
            produtoEncontrado = ObterPorId(produto.Id);
            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Marca = produto.Marca;
            produtoEncontrado.CodigoBarras = produto.CodigoBarras;
            produtoEncontrado.DataVencimento = produto.DataVencimento;
        }
        public Produto ObterPorId(int id)
        {
            produtoEncontrado = listaSingleton.ListaProdutos.FirstOrDefault(x => x.Id == id) ??
                throw new Exception($"Produto não encontrado com id: {id}");

            return produtoEncontrado;
        }

        public List<Produto> ObterTodos()
        {
            return listaSingleton.ListaProdutos;
        }
    }
}
