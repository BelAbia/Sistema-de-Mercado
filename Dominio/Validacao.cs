namespace Sistema_de_Mercado
{
    public class Validacao
    {
        string? mensagem;
        List<string> avisos = new();
        string valorInicialPadraoParaCodigoDeBarras = "789";
        int tamanhoObrigatorioDoCodigoDeBarras = 13;
        int quantidadeMinimaDeAvisos = 1;

        public bool Validar(Produto produto)
        {
            if (string.IsNullOrEmpty(produto.Nome))
            {
                avisos.Add("O campo 'Nome do Produto' não pode ser vazio.");
            }
            if (string.IsNullOrEmpty(produto.Marca))
            {
                avisos.Add("O campo 'Marca' não pode ser vazio.");
            }
            if (string.IsNullOrEmpty(produto.CodigoBarras))
            {
                avisos.Add("O campo 'Codigo de barras' não pode ser vazio");
            }
            if (!produto.CodigoBarras.StartsWith(valorInicialPadraoParaCodigoDeBarras))
            {
                avisos.Add("O campo 'codigo do produto' deve começar, por padrão, com 789.");
            }
            if (produto.CodigoBarras.Length < tamanhoObrigatorioDoCodigoDeBarras)
            {
                avisos.Add("O campo 'Codigo de barras' deve conter 13 números inteiros.");
            }
            if (avisos.Count >= quantidadeMinimaDeAvisos)
            {
                mensagem = string.Join(Environment.NewLine, avisos);
                avisos.Clear();
                throw new Exception(mensagem);
            }
            else
            {
                return true;
            }
        }
    }
}