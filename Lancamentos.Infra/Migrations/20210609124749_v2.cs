using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lancamentos.Infra.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desenvolvedor_Projeto_ProjetoId1",
                table: "Desenvolvedor");

            migrationBuilder.DropIndex(
                name: "IX_Desenvolvedor_ProjetoId1",
                table: "Desenvolvedor");

            migrationBuilder.DropColumn(
                name: "ProjetoId1",
                table: "Desenvolvedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProjetoId1",
                table: "Desenvolvedor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Desenvolvedor_ProjetoId1",
                table: "Desenvolvedor",
                column: "ProjetoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Desenvolvedor_Projeto_ProjetoId1",
                table: "Desenvolvedor",
                column: "ProjetoId1",
                principalTable: "Projeto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
