using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransporteV1API.Migrations
{
    public partial class AddFrete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fretes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Origem = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destino = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorTotal = table.Column<float>(type: "float", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdCliente = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdCaminhao = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fretes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fretes_Caminhaos_IdCaminhao",
                        column: x => x.IdCaminhao,
                        principalTable: "Caminhaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fretes_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parcelas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Valor = table.Column<float>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdFrete = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parcelas_Fretes_IdFrete",
                        column: x => x.IdFrete,
                        principalTable: "Fretes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Fretes_IdCaminhao",
                table: "Fretes",
                column: "IdCaminhao");

            migrationBuilder.CreateIndex(
                name: "IX_Fretes_IdCliente",
                table: "Fretes",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Parcelas_IdFrete",
                table: "Parcelas",
                column: "IdFrete");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parcelas");

            migrationBuilder.DropTable(
                name: "Fretes");
        }
    }
}
