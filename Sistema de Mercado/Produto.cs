using System;
using System.Runtime.CompilerServices;

namespace Sistema_de_Mercado
{
    public class Produto
    {
        public int Id {      get; set; }
        public string? Nome { get; set; }
        public string? Marca { get; set; }
        public long CodigoBarras { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataCadastro { get; set; }
        
    }
}