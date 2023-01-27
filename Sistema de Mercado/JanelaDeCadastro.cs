using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    
    public partial class JanelaDeCadastro : Form
    {
        Produto produto = new Produto();
        static int nextId = 1;
        Produto ProdutoASerAtualizado;
        string? mensagem;
        List<string> avisos = new List<string>();
        public void AtribuindoValores()
        {

            try
            {   
                produto.Id = JanelaDeLista.IdEditar;
                produto.Nome = tb_NomeProduto.Text;
                produto.Marca = tb_Marca.Text;
                produto.CodigoBarras = (tb_CodBarras.Text);
                produto.DataVencimento = dt_Vencimento.Value;
                produto.DataCadastro = DateTime.Now;

                
                if (string.IsNullOrEmpty(produto.Nome))
                {
                    avisos.Add("O campo 'Nome do Produto' não aceita valor nulo.");
                }
                if (string.IsNullOrEmpty(produto.Marca))
                {
                    avisos.Add("O campo 'Marca' não aceita valor nulo.");
                }
                if (string.IsNullOrEmpty(tb_CodBarras.Text))
                {
                    avisos.Add("O campo 'Codigo de barras' não aceita valor nulo");
                }
                if (!tb_CodBarras.Text.StartsWith("789"))
                {
                    avisos.Add("O campo 'codigo do produto' deve começar, por padrão, com 789");
                }
                if (tb_CodBarras.Text.Length < 13)
                {
                    avisos.Add("O campo 'Codigo de barras' deve conter 13 números inteiros");
                }         
                if (avisos.Count > 0)
                {
                    mensagem = string.Join(Environment.NewLine, avisos);
                    MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    avisos.Clear();
                }

                else if (produto.Id != 0)
                {
                    for (int i = 0; i < JanelaDeLista.listaProdutos.Count; i++)
                    {
                        if (produto.Id == JanelaDeLista.listaProdutos[i].Id) 
                        {
                            JanelaDeLista.listaProdutos[i].Marca = produto.Marca;
                            JanelaDeLista.listaProdutos[i].Nome = produto.Nome;
                            JanelaDeLista.listaProdutos[i].CodigoBarras = produto.CodigoBarras;
                            JanelaDeLista.listaProdutos[i].DataVencimento = produto.DataVencimento;
                            this.DialogResult = DialogResult.OK;
                            break;
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public JanelaDeCadastro()
        {
            InitializeComponent();
        }
         
        private void AoClicarBotaoSalvar(object sender, EventArgs e)
         {
                AtribuindoValores();
        }
        public void ValoresASerAtualiados(Produto produto)
        {
            ProdutoASerAtualizado = produto;
            tb_Marca.Text = ProdutoASerAtualizado.Marca;
            tb_CodBarras.Text = produto.CodigoBarras;
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
        private void tb_CodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}