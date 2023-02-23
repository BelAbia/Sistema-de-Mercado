using LinqToDB.Mapping;
namespace Sistema_de_Mercado
{
    public class Produto
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [NotNull]
        public string? Nome { get; set; }

        [NotNull]
        public string? Marca { get; set; }

        [NotNull]
        public string? CodigoBarras { get; set; }

        [NotNull]
        public DateTime DataVencimento { get; set; }

        [NotNull]
        public DateTime DataCadastro { get; set; }
    }
}