using Microsoft.EntityFrameworkCore.Migrations;

namespace Lancamentos.Infra.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Projeto",
                newName: "NomeProjeto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeProjeto",
                table: "Projeto",
                newName: "Nome");
        }
    }
}
