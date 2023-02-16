namespace Sistema_de_Mercado
{
    internal sealed class ListaSingleton
    {
        private static ListaSingleton? instance;
        private List<Produto> listaProdutos = new();
        static int proximoId = 0;

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

        public int ProximoId(Produto produto)
        {
            proximoId++;
            produto.Id = proximoId;

            return proximoId;
        }
    }
}