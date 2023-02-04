using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableNCM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NCM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoNCM = table.Column<string>(name: "Codigo_NCM", type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    DescricaoConcatenada = table.Column<string>(name: "Descricao_Concatenada", type: "text", nullable: true),
                    DataInicio = table.Column<DateOnly>(name: "Data_Inicio", type: "date", nullable: true),
                    DataFim = table.Column<DateOnly>(name: "Data_Fim", type: "date", nullable: true),
                    AtoLegal = table.Column<string>(name: "Ato_Legal", type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Ano = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCM", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NCM");
        }
    }
}
