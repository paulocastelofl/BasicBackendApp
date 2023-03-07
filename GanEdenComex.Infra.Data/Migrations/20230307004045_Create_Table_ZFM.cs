using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableZFM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZFM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RepresentanteLegal = table.Column<int>(type: "integer", nullable: true),
                    NumeroSequencialPLI = table.Column<string>(type: "text", nullable: true),
                    SenhaSuframa = table.Column<string>(type: "text", nullable: true),
                    Industria = table.Column<bool>(type: "boolean", nullable: true),
                    DTE = table.Column<bool>(type: "boolean", nullable: true),
                    ResponsavelSefaz = table.Column<bool>(type: "boolean", nullable: true),
                    OptanteLei2826 = table.Column<bool>(type: "boolean", nullable: true),
                    ArmazenaArquivoRetornoPLI = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZFM", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZFM");
        }
    }
}
