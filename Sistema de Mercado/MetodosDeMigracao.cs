using FluentMigrator;
namespace Sistema_de_Mercado
{
    [Migration(20230213101300)]
    public class MetodosDeMigracao : Migration
    {
        public override void Up()
        {
            Create.Table("tb_produto")
             .WithColumn("Id").AsInt64().PrimaryKey().Identity().NotNullable()
             .WithColumn("nome").AsString(100).NotNullable()
             .WithColumn("marca").AsString(100).NotNullable()
             .WithColumn("codigo_barras").AsString(13).NotNullable()
             .WithColumn("data_vencimento").AsDateTime().NotNullable()
             .WithColumn("data_cadastro").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("tb_produto");
        }
    }
}