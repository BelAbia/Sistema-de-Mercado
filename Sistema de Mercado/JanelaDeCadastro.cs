using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    public partial class JanelaDeCadastro : Form
    {
        Produto produto = new Produto();
        JanelaDeLista novaJanelaLista = new JanelaDeLista();
        public JanelaDeCadastro()
        {
            InitializeComponent();
        }

        private void AoClicarBotaoSalvar(object sender, EventArgs e)
         {
            if ( JanelaDeLista.listaProdutos.Count == 0)
            {
                Produto produto = new Produto();
                
                produto.Nome = tb_NomeProduto.Text;
                produto.Marca = tb_Marca.Text;
                produto.CodigoBarras = int.Parse(tb_CodBarras.Text);
                produto.DataVencimento = dt_Vencimento.Value;
                produto.DataCadastro = DateTime.Now;
                JanelaDeLista.listaProdutos.Add(produto);
                this.DialogResult = DialogResult.OK;
            } else 
            {
                produto.Nome = tb_NomeProduto.Text;
                produto.Marca = tb_Marca.Text;
                produto.CodigoBarras = int.Parse(tb_CodBarras.Text);
                produto.DataVencimento = dt_Vencimento.Value;
                produto.DataCadastro = DateTime.Now;
                JanelaDeLista.listaProdutos.Add(produto);
                this.Hide();
                novaJanelaLista.ShowDialog();
            }
           
        }

        private void AoClicarBotaoCancelar(object sender, EventArgs e)
        {
            
            this.Hide();
        }


        private void Janela2_Load(object sender, EventArgs e)
        {
            dt_Vencimento.MinDate = DateTime.Now;
        }

      
    }
}