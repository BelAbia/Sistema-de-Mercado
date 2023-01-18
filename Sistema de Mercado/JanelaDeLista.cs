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

        private void JanelaDeLista_Load(object sender, EventArgs e)
        {
            
            AtualizarDataGridView();
            
            
        }

        private void AoClicarBotaoOk(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
