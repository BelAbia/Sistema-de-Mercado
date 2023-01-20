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
        //OBRIGAR o usuário a digitar 789, caso nao, da um erro. Tirar do padrão.
    
    

    public void AtribuindoValores()
        {

            try
            {
                produto.Nome = tb_NomeProduto.Text;
                produto.Marca = tb_Marca.Text;
                produto.CodigoBarras = long.Parse(tb_CodBarras.Text);
                produto.DataVencimento = dt_Vencimento.Value;
                produto.DataCadastro = DateTime.Now;

                if (produto.Nome == string.Empty || produto.Marca == string.Empty)
                {
                    MessageBox.Show("Os campos 'Nome do Produto' e 'Marca' não aceitam valores nulos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else if (tb_CodBarras.Text.Length < 13)
                {
                    MessageBox.Show("O campo 'Codigo de barras' deve conter 13 números inteiros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    JanelaDeLista.listaProdutos.Add(produto);
                    ObterId();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (System.FormatException e)
            {
                MessageBox.Show("O campo 'Codigo de barras' só aceita valores numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }
        public JanelaDeCadastro()
        {
            InitializeComponent();
        }
         
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
            long numero = 789;
            dt_Vencimento.MinDate = DateTime.Now;
            tb_CodBarras.Text = numero.ToString();
        }

        private void NaoAceitarLetras(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;      
            }
        }

        private void tb_CodBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_CodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}