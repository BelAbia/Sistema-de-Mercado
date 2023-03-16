namespace Dominio
{
    public class MensagensDeErro
    {
        public string ErroParaAdicionarProduto = "Erro ao adicionar novo produto.";
        public string ErroParaAtualizarProduto = "Erro ao atualizar produto.";
        public string ErroParaDeletarProduto = "Erro ao deletar produto.";
        public string ErroParaObterListaDeProdutos = "Erro ao obter lista de produtos.";
        public string ErroParaObterProdutoPorId(int id)
        {
            string Mensagem = $"Erro ao obter produto com o id = {id}";
            return Mensagem;
        }
    }
}