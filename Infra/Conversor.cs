using System.Data;

namespace Sistema_de_Mercado
{
    internal class Conversor
    {
        public List<Produto> ConverteProduto(DataTable dt)
        {
            var list = new List<Produto>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Produto produto = new()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    Nome = dt.Rows[i]["nome"].ToString(),
                    Marca = dt.Rows[i]["marca"].ToString(),
                    CodigoBarras = dt.Rows[i]["codigo_barras"].ToString(),
                    DataVencimento = DateTime.Parse(dt.Rows[i]["data_vencimento"].ToString()),
                    DataCadastro = DateTime.Parse(dt.Rows[i]["data_cadastro"].ToString())
                };
                list.Add(produto);
            }
            return list;
        }
    }
}