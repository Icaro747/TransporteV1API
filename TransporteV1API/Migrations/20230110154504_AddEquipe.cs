using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransporteV1API.Migrations
{
    public partial class AddEquipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Comissao = table.Column<float>(type: "float", nullable: false),
                    IdFuncionario = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdFrete = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipes_Fretes_IdFrete",
                        column: x => x.IdFrete,
                        principalTable: "Fretes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipes_Funcionarios_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Equipes_IdFrete",
                table: "Equipes",
                column: "IdFrete");

            migrationBuilder.CreateIndex(
                name: "IX_Equipes_IdFuncionario",
                table: "Equipes",
                column: "IdFuncionario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipes");
        }
    }
}
