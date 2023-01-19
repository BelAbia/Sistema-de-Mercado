using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    public partial class JanelaDeCadastro : Form
    {
        Produto produto = new Produto();
        JanelaDeLista novaJanelaLista = new JanelaDeLista();

        public void ObterId()
        {
            for (int i = 0; i < JanelaDeLista.listaProdutos.Count; i++)
            {
                JanelaDeLista.listaProdutos[i].Id = i + 1;
            }
        }
    public void AtribuindoValores()
        {
                
                produto.Nome = tb_NomeProduto.Text;
                produto.Marca = tb_Marca.Text;
                produto.CodigoBarras = int.Parse(tb_CodBarras.Text);
                produto.DataVencimento = dt_Vencimento.Value;
                produto.DataCadastro = DateTime.Now;
                JanelaDeLista.listaProdutos.Add(produto);
                ObterId();
                this.DialogResult = DialogResult.OK;
             
        }
        public JanelaDeCadastro()
        {
            InitializeComponent();
        }
         
        //USAR MASKED TEXT BOX NO CODIGO DE BARRAS.
        //Arrumar o else, tirar coisas inúteis, fazer diversos testes e arrumar os próximos botoes (começando com o Delete) fazer o ID.
        private void AoClicarBotaoSalvar(object sender, EventArgs e)
         {
            
            if ( JanelaDeLista.listaProdutos.Count == 0)
            {
                Produto produto = new Produto();
                AtribuindoValores();
                
            } else 
            {
                AtribuindoValores();
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

        private void tb_CodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;      
            }

        }

        private void tb_CodBarras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}