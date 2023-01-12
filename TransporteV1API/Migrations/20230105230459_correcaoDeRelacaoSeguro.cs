using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransporteV1API.Migrations
{
    public partial class correcaoDeRelacaoSeguro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caminhaos_Seguros_SeguroId",
                table: "Caminhaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_Caminhaos_IdCamiao",
                table: "Seguros");

            migrationBuilder.DropIndex(
                name: "IX_Seguros_IdCamiao",
                table: "Seguros");

            migrationBuilder.DropIndex(
                name: "IX_Caminhaos_SeguroId",
                table: "Caminhaos");

            migrationBuilder.DropColumn(
                name: "SeguroId",
                table: "Caminhaos");

            migrationBuilder.RenameColumn(
                name: "IdCamiao",
                table: "Seguros",
                newName: "IdCaminhao");

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_IdCaminhao",
                table: "Seguros",
                column: "IdCaminhao",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_Caminhaos_IdCaminhao",
                table: "Seguros",
                column: "IdCaminhao",
                principalTable: "Caminhaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_Caminhaos_IdCaminhao",
                table: "Seguros");

            migrationBuilder.DropIndex(
                name: "IX_Seguros_IdCaminhao",
                table: "Seguros");

            migrationBuilder.RenameColumn(
                name: "IdCaminhao",
                table: "Seguros",
                newName: "IdCamiao");

            migrationBuilder.AddColumn<Guid>(
                name: "SeguroId",
                table: "Caminhaos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_IdCamiao",
                table: "Seguros",
                column: "IdCamiao");

            migrationBuilder.CreateIndex(
                name: "IX_Caminhaos_SeguroId",
                table: "Caminhaos",
                column: "SeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caminhaos_Seguros_SeguroId",
                table: "Caminhaos",
                column: "SeguroId",
                principalTable: "Seguros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_Caminhaos_IdCamiao",
                table: "Seguros",
                column: "IdCamiao",
                principalTable: "Caminhaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
