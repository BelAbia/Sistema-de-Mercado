namespace Sistema_de_Mercado
{
    public partial class JanelaDeCadastro : Form
    {
        private IRepositorio _repositorio;
        Validacao validacao = new();
        Produto produto = new();

        public JanelaDeCadastro(IRepositorio repositorio)
        {
            _repositorio = repositorio;
            InitializeComponent();
        }

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

        private void AoClicarBotaoSalvar(object sender, EventArgs e)
        {
            const int ValorNecessarioParaAdicionarNovoProduto = 0;
            AtribuindoValores();

            try
            {
                if (validacao.Validar(produto))
                {
                    if (produto.Id == ValorNecessarioParaAdicionarNovoProduto)
                    {
                        _repositorio.AdicionarProduto(produto);
                    }
                    else
                    {
                        _repositorio.AtualizarProduto(produto);
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
            var produtoASerAtualizado = produto;
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
            const int backSpace = (char)8;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != backSpace)
            {
                e.Handled = true;
            }
        }
    }
}