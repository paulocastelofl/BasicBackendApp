using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdExTIPI",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "extipiId",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_extipiId",
                table: "Item",
                column: "extipiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ExTIPI_extipiId",
                table: "Item",
                column: "extipiId",
                principalTable: "ExTIPI",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ExTIPI_extipiId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_extipiId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdExTIPI",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "extipiId",
                table: "Item");
        }
    }
}
