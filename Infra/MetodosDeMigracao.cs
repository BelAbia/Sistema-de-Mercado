using FluentMigrator;
namespace Sistema_de_Mercado
{
    [Migration(20230213101300)]
    public class MetodosDeMigracao : Migration
    {
        public override void Up()
        {
            Create.Table("Produto")
             .WithColumn("Id").AsInt64().PrimaryKey().Identity().NotNullable()
             .WithColumn("Nome").AsString(100).NotNullable()
             .WithColumn("Marca").AsString(100).NotNullable()
             .WithColumn("CodigoBarras").AsString(13).NotNullable()
             .WithColumn("DataVencimento").AsDateTime().NotNullable()
             .WithColumn("DataCadastro").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("tb_produto");
        }
    }
}