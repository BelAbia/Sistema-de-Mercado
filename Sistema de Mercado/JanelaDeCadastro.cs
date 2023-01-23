using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    
    public partial class JanelaDeCadastro : Form
    {
        Produto produto = new Produto();
        static int nextId = 1;

        //OBRIGAR o usu�rio a digitar 789, caso nao, da um erro. Tirar do padr�o.
    
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
                    MessageBox.Show("Os campos 'Nome do Produto' e 'Marca' n�o aceitam valores nulos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else if (tb_CodBarras.Text.Length < 13)
                {
                    MessageBox.Show("O campo 'Codigo de barras' deve conter 13 n�meros inteiros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!tb_CodBarras.Text.StartsWith("789"))
                {
                    MessageBox.Show("O codigo do produto deve come�ar, por padr�o, com 789", "Tela de exclus�o", MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                }
                else
                {
                    produto.Id = nextId;
                    nextId++;
                    JanelaDeLista.listaProdutos.Add(produto);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (System.FormatException e)
            {
                MessageBox.Show("O campo 'Codigo de barras' s� aceita valores num�ricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dt_Vencimento.MinDate = DateTime.Now;
            
        }

        private void NaoAceitarLetras(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;      
            }
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