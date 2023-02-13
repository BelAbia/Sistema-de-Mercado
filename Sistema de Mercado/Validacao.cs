using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Mercado
{
    internal class Validacao
    {
        Produto produto = new();
        //JanelaDeCadastro janela = new();
        string? mensagem;
        List<string> avisos = new();

        public List<string> Validar (Produto produto)
        {
           
                
                if (string.IsNullOrEmpty(produto.Nome))
                {
                    avisos.Add("O campo 'Nome do Produto' não pode ser vazio.");
                }
                else if (string.IsNullOrEmpty(produto.Marca))
                {
                    avisos.Add("O campo 'Marca' não pode ser vazio.");
                }
                else if (string.IsNullOrEmpty(produto.CodigoBarras))
                {
                    avisos.Add("O campo 'Codigo de barras' não pode ser vazio");
                }
                else if (produto.CodigoBarras.StartsWith("789"))
                {
                    avisos.Add("O campo 'codigo do produto' deve começar, por padrão, com 789.");
                }
                else if (produto.CodigoBarras.Length < 13)
                {
                    avisos.Add("O campo 'Codigo de barras' deve conter 13 números inteiros.");
                }
                if (avisos.Count > 0)
                {
                    mensagem = string.Join(Environment.NewLine, avisos);
                    MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    avisos.Clear();
                   
                } 
                
                return avisos;
        }
    }
}
