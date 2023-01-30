using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    
    public partial class JanelaDeCadastro : Form
    {

        ListaSingleton ListaSingleton = ListaSingleton.GetInstance();
        Produto produto = new();
        static int nextId = 1;
        Produto produtoASerAtualizado;
        string? mensagem;
        List<string> avisos = new();
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
                    avisos.Add("O campo 'Nome do Produto' não pode ser vazio.");
                }
                if (string.IsNullOrEmpty(produto.Marca))
                {
                    avisos.Add("O campo 'Marca' não pode ser vazio.");
                }
                if (string.IsNullOrEmpty(tb_CodBarras.Text))
                {
                    avisos.Add("O campo 'Codigo de barras' não pode ser vazio");
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
                    for (int i = 0; i < ListaSingleton.ListaProdutos.Count; i++)
                    {
                        if (produto.Id == ListaSingleton.ListaProdutos[i].Id) 
                        {
                            ListaSingleton.ListaProdutos[i].Marca = produto.Marca;
                            ListaSingleton.ListaProdutos[i].Nome = produto.Nome;
                            ListaSingleton.ListaProdutos[i].CodigoBarras = produto.CodigoBarras;
                            ListaSingleton.ListaProdutos[i].DataVencimento = produto.DataVencimento;
                            this.DialogResult = DialogResult.OK;
                            break;
                        }
                    }
                }
                else
                {
                    produto.Id = nextId;
                    nextId++;
                    ListaSingleton.ListaProdutos.Add(produto);
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
            produtoASerAtualizado = produto;
            tb_Marca.Text = produtoASerAtualizado.Marca;
            tb_CodBarras.Text = produto.CodigoBarras;
            produto.DataCadastro = produtoASerAtualizado.DataCadastro;
            dt_Vencimento.Text = produtoASerAtualizado.DataVencimento.ToString();
            tb_NomeProduto.Text = produtoASerAtualizado.Nome;
            produto.Id = produtoASerAtualizado.Id;
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

        private void dt_Vencimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}