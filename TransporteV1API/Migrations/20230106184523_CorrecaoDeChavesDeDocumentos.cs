using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransporteV1API.Migrations
{
    public partial class CorrecaoDeChavesDeDocumentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Funcionarios_FuncionarioId",
                table: "Documentos");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "Documentos",
                newName: "IdFuncionario");

            migrationBuilder.RenameIndex(
                name: "IX_Documentos_FuncionarioId",
                table: "Documentos",
                newName: "IX_Documentos_IdFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Funcionarios_IdFuncionario",
                table: "Documentos",
                column: "IdFuncionario",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_Funcionarios_IdFuncionario",
                table: "Documentos");

            migrationBuilder.RenameColumn(
                name: "IdFuncionario",
                table: "Documentos",
                newName: "FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Documentos_IdFuncionario",
                table: "Documentos",
                newName: "IX_Documentos_FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_Funcionarios_FuncionarioId",
                table: "Documentos",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
