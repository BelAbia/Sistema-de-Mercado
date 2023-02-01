using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Mercado
{
    public class Repositorio : IRepositorio
    {
        Produto produto = new();
        ListaSingleton listaSingleton = ListaSingleton.GetInstance();

        public void NovoProduto(Produto produto)
        {
           listaSingleton.ListaProdutos.Add(produto);

        }

        public void DeletarProduto(int linhaSelecionada)
        {
           listaSingleton.ListaProdutos.RemoveAt(linhaSelecionada);

        }

        public void AtualizarProduto(int i, Produto produto)
        {
            listaSingleton.ListaProdutos[i].Marca = produto.Marca;
            listaSingleton.ListaProdutos[i].Nome = produto.Nome;
            listaSingleton.ListaProdutos[i].CodigoBarras = produto.CodigoBarras;
            listaSingleton.ListaProdutos[i].DataVencimento = produto.DataVencimento;
        }
        public void ObterPorId(int id)
        {
            //listaSingleton.ListaProdutos.Find(x );
           // parts.Find(x => x.PartName.Contains("seat")));
        }

        public List<Produto> ObterTodos()
        {
            return listaSingleton.ListaProdutos;
        }

    }
}
