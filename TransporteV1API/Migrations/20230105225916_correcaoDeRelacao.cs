using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransporteV1API.Migrations
{
    public partial class correcaoDeRelacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caminhaos_Financiamentos_FinanciamentoId",
                table: "Caminhaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Financiamentos_Caminhaos_IdCamiao",
                table: "Financiamentos");

            migrationBuilder.DropIndex(
                name: "IX_Financiamentos_IdCamiao",
                table: "Financiamentos");

            migrationBuilder.DropIndex(
                name: "IX_Caminhaos_FinanciamentoId",
                table: "Caminhaos");

            migrationBuilder.DropColumn(
                name: "FinanciamentoId",
                table: "Caminhaos");

            migrationBuilder.RenameColumn(
                name: "IdCamiao",
                table: "Financiamentos",
                newName: "IdCaminhao");

            migrationBuilder.CreateIndex(
                name: "IX_Financiamentos_IdCaminhao",
                table: "Financiamentos",
                column: "IdCaminhao",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Financiamentos_Caminhaos_IdCaminhao",
                table: "Financiamentos",
                column: "IdCaminhao",
                principalTable: "Caminhaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Financiamentos_Caminhaos_IdCaminhao",
                table: "Financiamentos");

            migrationBuilder.DropIndex(
                name: "IX_Financiamentos_IdCaminhao",
                table: "Financiamentos");

            migrationBuilder.RenameColumn(
                name: "IdCaminhao",
                table: "Financiamentos",
                newName: "IdCamiao");

            migrationBuilder.AddColumn<Guid>(
                name: "FinanciamentoId",
                table: "Caminhaos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Financiamentos_IdCamiao",
                table: "Financiamentos",
                column: "IdCamiao");

            migrationBuilder.CreateIndex(
                name: "IX_Caminhaos_FinanciamentoId",
                table: "Caminhaos",
                column: "FinanciamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caminhaos_Financiamentos_FinanciamentoId",
                table: "Caminhaos",
                column: "FinanciamentoId",
                principalTable: "Financiamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Financiamentos_Caminhaos_IdCamiao",
                table: "Financiamentos",
                column: "IdCamiao",
                principalTable: "Caminhaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
