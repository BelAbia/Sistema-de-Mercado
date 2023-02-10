using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Mercado
{
    internal sealed class ListaSingleton
    {

        private static ListaSingleton? instance;
        private List<Produto> listaProdutos = new();

    private ListaSingleton()
    {

    }

    public static ListaSingleton GetInstance()
    {
            if (instance == null)
            {
                instance = new ListaSingleton();
            }
        return instance;
              
    }
    public List<Produto> ListaProdutos
    {
        get { return listaProdutos; }
        set { listaProdutos = value; }
    }
        public int proximoId()
        {
            var idAtual = 1;
            
            return ++idAtual;
        }

    }
}
