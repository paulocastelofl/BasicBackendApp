using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableAtoLegal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtoLegal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Numero = table.Column<int>(type: "integer", nullable: true),
                    Tipo = table.Column<string>(type: "text", nullable: true),
                    Orgao = table.Column<string>(type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Geral = table.Column<bool>(type: "boolean", nullable: true),
                    Ativo = table.Column<bool>(type: "boolean", nullable: true),
                    VincularProcessos = table.Column<bool>(type: "boolean", nullable: true),
                    RegimeIPI = table.Column<string>(type: "text", nullable: true),
                    FundamentoII = table.Column<string>(type: "text", nullable: true),
                    RegimePISCOFINS = table.Column<string>(type: "text", nullable: true),
                    FundamentoPISCOFINS = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtoLegal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtoLegal_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtoLegal_IdEmpresa",
                table: "AtoLegal",
                column: "IdEmpresa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtoLegal");
        }
    }
}
