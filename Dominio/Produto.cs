using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Mercado
{
    public class Produto
    {
        [Required(ErrorMessage ="erro")]
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [NotNull]
        public string Nome { get; set; }

        [NotNull]
        public string Marca { get; set; }

        [NotNull]
        public string CodigoBarras { get; set; }

        [NotNull]
        public DateTime DataVencimento { get; set; }

        [NotNull]
        public DateTime DataCadastro { get; set; }
    }
}