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
        Produto produto = new Produto();
        public static int IdEditar;
        public int selectedRow;

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
            } catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nenhum produto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void dgv_Produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }
        //public void EditarValores(Produto produtoEditado)
        //{
        //    for (int i = 0; i < listaProdutos.Count; i++)
        //    {
        //        if (listaProdutos[i].Id == produtoEditado.Id)
        //        {
        //            listaProdutos[i] = produtoEditado;
        //            break;
        //        }
        //        AtualizarDataGridView();
        //    }
        //}
        private void AoClicarAtualizar(object sender, EventArgs e)
        {
            var indexSelecionado = dgv_Produto.CurrentRow.Index;
            var produtoASerAtualizado = dgv_Produto.Rows[indexSelecionado].DataBoundItem as Produto;
            if (produtoASerAtualizado != null)
            {
                var dataGrid = dgv_Produto.SelectedRows;
                JanelaDeCadastro novaJanelaDeCadastro = new JanelaDeCadastro();
                novaJanelaDeCadastro.ValoresASerAtualiados(produtoASerAtualizado);
                IdEditar = produtoASerAtualizado.Id;
                novaJanelaDeCadastro.ShowDialog();

            }

            AtualizarDataGridView();
        }

    }
}
