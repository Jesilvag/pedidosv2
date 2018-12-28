using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class RelacionMarcaProductosMigrationv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marca_Marca_Id",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marca",
                table: "Marca");

            migrationBuilder.RenameTable(
                name: "Marca",
                newName: "Marcas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marcas",
                table: "Marcas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_Marca_Id",
                table: "Productos",
                column: "Marca_Id",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_Marca_Id",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marcas",
                table: "Marcas");

            migrationBuilder.RenameTable(
                name: "Marcas",
                newName: "Marca");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marca",
                table: "Marca",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marca_Marca_Id",
                table: "Productos",
                column: "Marca_Id",
                principalTable: "Marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
