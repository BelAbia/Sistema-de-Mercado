using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    
    public partial class JanelaDeCadastro : Form
    {
        Produto produto = new Produto();
        static int nextId = 1;
        Produto ProdutoASerAtualizado;

        
        //OBRIGAR o usuário a digitar 789, caso nao, da um erro. Tirar do padrão.
    
    public void AtribuindoValores()
        {

            try
            {
                produto.Id = JanelaDeLista.IdEditar;
                produto.Nome = tb_NomeProduto.Text;
                produto.Marca = tb_Marca.Text;
                produto.CodigoBarras = long.Parse(tb_CodBarras.Text);
                produto.DataVencimento = dt_Vencimento.Value;
                produto.DataCadastro = DateTime.Now;
                

                if (produto.Nome == string.Empty || produto.Marca == string.Empty)
                {
                    MessageBox.Show("Os campos 'Nome do Produto' e 'Marca' não aceitam valores nulos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else if (tb_CodBarras.Text.Length < 13)
                {
                    MessageBox.Show("O campo 'Codigo de barras' deve conter 13 números inteiros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!tb_CodBarras.Text.StartsWith("789"))
                {
                    MessageBox.Show("O codigo do produto deve começar, por padrão, com 789", "Tela de exclusão", MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                }
                else if (produto.Id != 0)
                {
                    for (int i = 0; i <= JanelaDeLista.listaProdutos.Count; i++)
                    {
                        if (produto.Id == JanelaDeLista.IdEditar)
                        {
                            JanelaDeLista.listaProdutos[i].Marca = produto.Marca;
                            JanelaDeLista.listaProdutos[i].Nome = produto.Nome;
                            JanelaDeLista.listaProdutos[i].CodigoBarras = produto.CodigoBarras;
                            JanelaDeLista.listaProdutos[i].DataVencimento = produto.DataVencimento;

                        }
                        else
                        {
                            produto.Id = nextId;
                            nextId++;
                            JanelaDeLista.listaProdutos.Add(produto);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    produto.Id = nextId;
                    nextId++;
                    JanelaDeLista.listaProdutos.Add(produto);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("O campo 'Codigo de barras' só aceita valores numéricos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void ValoresASerAtualiados(Produto produto)
        {
            ProdutoASerAtualizado = produto;
            tb_Marca.Text = ProdutoASerAtualizado.Marca;
            tb_CodBarras.Text = produto.CodigoBarras.ToString();
            produto.DataCadastro = ProdutoASerAtualizado.DataCadastro;
            dt_Vencimento.Text = ProdutoASerAtualizado.DataVencimento.ToString();
            tb_NomeProduto.Text = ProdutoASerAtualizado.Nome;
            produto.Id = ProdutoASerAtualizado.Id;
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