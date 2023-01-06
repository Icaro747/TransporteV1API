using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransporteV1API.Migrations
{
    public partial class CorrecaoDeChavesDeGastos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Caminhaos_CaminhaoId",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_CaminhaoId",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "CaminhaoId",
                table: "Gastos");

            migrationBuilder.RenameColumn(
                name: "IdCamiao",
                table: "Gastos",
                newName: "IdCaminhao");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_IdCaminhao",
                table: "Gastos",
                column: "IdCaminhao");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Caminhaos_IdCaminhao",
                table: "Gastos",
                column: "IdCaminhao",
                principalTable: "Caminhaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Caminhaos_IdCaminhao",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_IdCaminhao",
                table: "Gastos");

            migrationBuilder.RenameColumn(
                name: "IdCaminhao",
                table: "Gastos",
                newName: "IdCamiao");

            migrationBuilder.AddColumn<Guid>(
                name: "CaminhaoId",
                table: "Gastos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_CaminhaoId",
                table: "Gastos",
                column: "CaminhaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Caminhaos_CaminhaoId",
                table: "Gastos",
                column: "CaminhaoId",
                principalTable: "Caminhaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
