namespace Sistema_de_Mercado
{
    public partial class Janela2 : Form
    {
        public Janela2()
        {
            InitializeComponent();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto();        

            produto.Nome = tb_NomeProduto.Text;
            produto.Marca = tb_Marca.Text;
            produto.CodigoBarras = int.Parse(tb_CodBarras.Text);
            produto.DataVencimento = DateTime.Parse(dt_Vencimento.Text);
            produto.DataCadastro = DateTime.Parse(dt_Cadastro.Text);





        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            Janela1 janela1 = new Janela1();
            janela1.Show();
            this.Hide();
        }

        private void dt_Cadastro_ValueChanged(object sender, EventArgs e)
        {
            dt_Cadastro.Value = DateTime.Now.Date;
            dt_Cadastro.MaxDate = DateTime.Now.Date;
            dt_Cadastro.MinDate = DateTime.Now.Date;
        }

        private void dt_Vencimento_ValueChanged(object sender, EventArgs e)
        {
            dt_Vencimento.Value = DateTime.Now.Date;
        }
    }
}