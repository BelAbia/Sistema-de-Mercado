namespace Sistema_de_Mercado
{
    internal class Validacao
    {
        string? mensagem;
        List<string> avisos = new();

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
            if (!produto.CodigoBarras.StartsWith("789"))
            {
                avisos.Add("O campo 'codigo do produto' deve começar, por padrão, com 789.");
            }
            if (produto.CodigoBarras.Length < 13)
            {
                avisos.Add("O campo 'Codigo de barras' deve conter 13 números inteiros.");
            }
            if (avisos.Count > 0)
            {
                mensagem = string.Join(Environment.NewLine, avisos);
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                avisos.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
