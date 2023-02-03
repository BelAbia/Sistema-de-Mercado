using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    public partial class JanelaDeLista : Form
    {
       
        Repositorio repositorio = new();
        public static int IdEditar;
        public int selectedRow;
        public JanelaDeLista()
        {
            InitializeComponent();
        }

        private void AoClicarBotaoNovo(object sender, EventArgs e)
        {
            IdEditar = 0;
            JanelaDeCadastro novaJanela = new JanelaDeCadastro();
            novaJanela.ShowDialog();
            AtualizarDataGridView();
        }

        private void AoClicarBotaoCancelar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AtualizarDataGridView()
        {
            dgv_Produto.DataSource = repositorio.ObterTodos().ToList();
            dgv_Produto.Refresh();
            dgv_Produto.Update();
        }
        private void AoClicarBotaoOk(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AoClicarDeletar(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Produto.CurrentCell != null)
                {
                    var decisaoExcluir = MessageBox.Show("Deseja excluir o produto?", "Tela de exclusão", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (decisaoExcluir == DialogResult.Yes)
                    {
                        repositorio.DeletarProduto(selectedRow);
                        AtualizarDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum produto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AoClicarDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void AoClicarAtualizar(object sender, EventArgs e)
        {
            if (dgv_Produto.CurrentCell != null)
            {

                try
                {
                    var indexSelecionado = dgv_Produto.CurrentRow.Index;
                    var produtoASerAtualizado = dgv_Produto.Rows[indexSelecionado].DataBoundItem as Produto;
                    if (produtoASerAtualizado != null)
                    {
                        var dataGrid = dgv_Produto.SelectedRows;
                        JanelaDeCadastro novaJanelaDeCadastro = new();
                        novaJanelaDeCadastro.ValoresASerAtualiados(produtoASerAtualizado);
                        IdEditar = produtoASerAtualizado.Id;
                        novaJanelaDeCadastro.ShowDialog();
                    }

                    AtualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
