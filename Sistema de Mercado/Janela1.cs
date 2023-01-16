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
    public partial class Janela1 : Form
    {
        public Janela1()
        {
            InitializeComponent();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            Janela2 janela2 = new Janela2();
            janela2.Show();
            this.Hide();
        }

        private void bt_Cancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
