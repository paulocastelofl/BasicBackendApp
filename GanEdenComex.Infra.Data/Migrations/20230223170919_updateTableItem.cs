using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdEmpresa",
                table: "Item",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Empresa_IdEmpresa",
                table: "Item",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Empresa_IdEmpresa",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_IdEmpresa",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Item");
        }
    }
}
