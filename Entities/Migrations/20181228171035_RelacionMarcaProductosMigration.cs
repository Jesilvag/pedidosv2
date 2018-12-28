using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class RelacionMarcaProductosMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marca_MarcaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Productos");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Marca",
                type: "VARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Marca_Id",
                table: "Productos",
                column: "Marca_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marca_Marca_Id",
                table: "Productos",
                column: "Marca_Id",
                principalTable: "Marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marca_Marca_Id",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_Marca_Id",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Productos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Marca",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marca_MarcaId",
                table: "Productos",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
