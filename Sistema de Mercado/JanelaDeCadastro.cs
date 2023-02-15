namespace Sistema_de_Mercado
{
    public partial class JanelaDeCadastro : Form
    {
        RepositorioBancoDeDados repositorio = new();
        Validacao validacao = new();
        Produto produto = new Produto();
        Produto produtoASerAtualizado;

        public void AtribuindoValores()
        {
            try
            {
                produto.Id = JanelaDeLista.IdEditar;
                produto.Nome = tb_NomeProduto.Text;
                produto.Marca = tb_Marca.Text;
                produto.CodigoBarras = (tb_CodBarras.Text);
                produto.DataVencimento = dt_Vencimento.Value;
                produto.DataCadastro = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public JanelaDeCadastro()
        {
            InitializeComponent();
        }

        private void AoClicarBotaoSalvar(object sender, EventArgs e)
        {
            AtribuindoValores();
            try
            {
                if (validacao.ValidarProduto(produto))
                {
                    if (produto.Id == 0)
                    {
                        repositorio.AdicionarProduto(produto);
                    }
                    else
                    {
                        repositorio.AtualizarProduto(produto);
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PassarValorParaTextBox(Produto produto)
        {
            produtoASerAtualizado = produto;
            tb_Marca.Text = produtoASerAtualizado.Marca;
            tb_CodBarras.Text = produtoASerAtualizado.CodigoBarras;
            produto.DataCadastro = produtoASerAtualizado.DataCadastro;
            dt_Vencimento.Text = produtoASerAtualizado.DataVencimento.ToString();
            tb_NomeProduto.Text = produtoASerAtualizado.Nome;
            produto.Id = produtoASerAtualizado.Id;
        }

        private void AoClicarBotaoCancelar(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AoCarregarJanelaDeCadastro(object sender, EventArgs e)
        {
            dt_Vencimento.MinDate = DateTime.Now;
        }

        private void AoDigitarCodigoDeBarras(object sender, KeyPressEventArgs e)
        {
            const int backspace = (char)8;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != backspace)
            {
                e.Handled = true;
            }
        }
    }
}