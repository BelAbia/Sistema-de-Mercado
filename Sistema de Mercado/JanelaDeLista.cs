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

        public static List<Produto> listaProdutos = new List<Produto>();
        public int selectedRow;
        JanelaDeCadastro novaJanelaDeCadastro = new JanelaDeCadastro();

        public JanelaDeLista()
        {
            InitializeComponent();
        }

        private void AoClicarBotaoNovo(object sender, EventArgs e)
        {
            
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
            dgv_Produto.DataSource = listaProdutos.ToList();
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

                var decisaoExcluir = MessageBox.Show("Deseja excluir o produto?", "Tela de exclusão", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (decisaoExcluir == DialogResult.Yes)
                {
                    listaProdutos.RemoveAt(selectedRow);
                    AtualizarDataGridView();
                }
            } catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Não há produtos para deletar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void dgv_Produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void AoClicarAtualizar(object sender, EventArgs e)
        {
            var indexSelecionado = dgv_Produto.CurrentRow.Index;
            var produtoASerAtualizado = dgv_Produto.Rows[indexSelecionado].DataBoundItem as Produto;

            var dataGrid = dgv_Produto.SelectedRows;


            
        }
    }
}
