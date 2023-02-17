namespace Sistema_de_Mercado
{
    public interface IRepositorio
    {
        public void AdicionarProduto(Produto produto);

        public void DeletarProduto(int LinhaSelecionada);

        public void AtualizarProduto(Produto produto);

        public List<Produto> ObterTodos();

        public Produto ObterPorId(int Id);
    }
}