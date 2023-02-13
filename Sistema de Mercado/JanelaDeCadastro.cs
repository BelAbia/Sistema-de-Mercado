using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    
    public partial class JanelaDeCadastro : Form
    {
        //Repositorio repositorio = new();
        RepositorioBancoDeDados repositorio = new();
        Validacao validacao = new();
        Produto produto = new Produto();
        static int nextId = 1;
        Produto produtoASerAtualizado;
        
        public void AtribuindoValores()
        {
            try
            {   
                // CLASSE DE VALIDAÇÃO NAO FUNCIONANDO
                produto.Id = JanelaDeLista.IdEditar;
                produto.Nome = tb_NomeProduto.Text;
                produto.Marca = tb_Marca.Text;
                produto.CodigoBarras = (tb_CodBarras.Text);
                produto.DataVencimento = dt_Vencimento.Value;
                produto.DataCadastro = DateTime.Now;


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void SalvarNovoProduto()
        {
            repositorio.NovoProduto(produto);
            this.DialogResult = DialogResult.OK;

        }

        public void AtualizarProduto()
        {
            repositorio.AtualizarProduto(produto);
            this.DialogResult = DialogResult.OK;

        }

        public JanelaDeCadastro()
        {
            InitializeComponent();
        }
         
        private void AoClicarBotaoSalvar(object sender, EventArgs e)
        {
            if (validacao.Validar(produto) != null)
            {
                AtribuindoValores();


            }

            if (produto.Id == 0)
            {
                SalvarNovoProduto();
            }
            else 
            {
                AtualizarProduto();
            }
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