using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransporteV1API.Migrations
{
    public partial class addseguro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_Camiaos_CamiaoId",
                table: "Seguros");

            migrationBuilder.RenameColumn(
                name: "CamiaoId",
                table: "Seguros",
                newName: "IdCamiao");

            migrationBuilder.RenameIndex(
                name: "IX_Seguros_CamiaoId",
                table: "Seguros",
                newName: "IX_Seguros_IdCamiao");

            migrationBuilder.AlterColumn<float>(
                name: "Valor",
                table: "Seguros",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Seguros",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_Camiaos_IdCamiao",
                table: "Seguros",
                column: "IdCamiao",
                principalTable: "Camiaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_Camiaos_IdCamiao",
                table: "Seguros");

            migrationBuilder.RenameColumn(
                name: "IdCamiao",
                table: "Seguros",
                newName: "CamiaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Seguros_IdCamiao",
                table: "Seguros",
                newName: "IX_Seguros_CamiaoId");

            migrationBuilder.AlterColumn<string>(
                name: "Valor",
                table: "Seguros",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Seguros",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_Camiaos_CamiaoId",
                table: "Seguros",
                column: "CamiaoId",
                principalTable: "Camiaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
