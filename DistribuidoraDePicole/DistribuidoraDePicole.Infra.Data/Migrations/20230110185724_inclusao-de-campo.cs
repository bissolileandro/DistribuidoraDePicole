using Microsoft.EntityFrameworkCore.Migrations;

namespace DistribuidoraDePicole.Infra.Data.Migrations
{
    public partial class inclusaodecampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentificadorProduto",
                table: "Venda",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentificadorProduto",
                table: "Venda");
        }
    }
}
