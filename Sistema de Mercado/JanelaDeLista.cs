namespace Sistema_de_Mercado
{
    public partial class JanelaDeLista : Form
    {
        private IRepositorio _repositorio;
        public static int IdEditar;

        public JanelaDeLista(IRepositorio repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
        }

        private void AoClicarBotaoNovo(object sender, EventArgs e)
        {
            IdEditar = 0;
            JanelaDeCadastro novaJanela = new JanelaDeCadastro(_repositorio);
            novaJanela.ShowDialog();
            AtualizarDataGridView();
        }

        private void AoClicarBotaoCancelar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AtualizarDataGridView()
        {
            dgv_Produto.DataSource = null;
            dgv_Produto.DataSource = _repositorio.ObterTodos().ToList();
            dgv_Produto.Refresh();
            dgv_Produto.Update();
        }

        public bool ValidarQuantidadeDeLinhasSelecionadasNoDataGrid(DataGridView dataGrid, string verbo)
        {
            const int numeroDeLinhasInvalidas = 2;
            if (dataGrid.SelectedRows.Count >= numeroDeLinhasInvalidas)
            {
                MessageBox.Show($"Não é permitido {verbo} mais de um produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {

                return true;
            }
        }

        private void AoClicarBotaoOk(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AoClicarDeletar(object sender, EventArgs e)
        {
            try
            {
                if (ValidarQuantidadeDeLinhasSelecionadasNoDataGrid(dgv_Produto, "deletar"))
                {
                    if (dgv_Produto.CurrentCell != null)
                    {
                        var indexSelecionado = dgv_Produto.CurrentRow.Index;
                        var produtoASerDeletado = dgv_Produto.Rows[indexSelecionado].DataBoundItem as Produto;
                        var decisaoExcluir = MessageBox.Show("Deseja excluir o produto?", "Tela de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (decisaoExcluir == DialogResult.Yes)
                        {
                            _repositorio.DeletarProduto(produtoASerDeletado.Id);
                            AtualizarDataGridView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AoClicarAtualizar(object sender, EventArgs e)
        {
            if (ValidarQuantidadeDeLinhasSelecionadasNoDataGrid(dgv_Produto, "atualizar"))
            {
                if (dgv_Produto.CurrentCell != null)
                {
                    try
                    {
                        var indexSelecionado = dgv_Produto.CurrentRow.Index;
                        var produtoASerAtualizado = dgv_Produto.Rows[indexSelecionado].DataBoundItem as Produto;

                        if (produtoASerAtualizado != null)
                        {
                            JanelaDeCadastro novaJanelaDeCadastro = new(_repositorio);
                            novaJanelaDeCadastro.PassarValorParaTextBox(produtoASerAtualizado);
                            IdEditar = produtoASerAtualizado.Id;
                            novaJanelaDeCadastro.ShowDialog();
                        }
                        AtualizarDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum produto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AoCarregarJanelaDeLista(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }
    }
}