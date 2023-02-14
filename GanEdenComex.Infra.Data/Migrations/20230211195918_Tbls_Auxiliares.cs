using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class TblsAuxiliares : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcordoAladi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcordoAladi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoberturaCambial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoberturaCambial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FundamentoLegal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundamentoLegal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadePagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ordem = table.Column<int>(type: "integer", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadePagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moeda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moeda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotivoSemCobertura_cambial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoSemCobertura_cambial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegimeTributavel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegimeTributavel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAcordoTarifario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAcordoTarifario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZFMAplicacaoMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZFMAplicacaoMaterial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZFMDestinacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZFMDestinacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZFMTributacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    aliquotaMva = table.Column<double>(type: "double precision", nullable: true),
                    aliquotaReducao = table.Column<double>(type: "double precision", nullable: true),
                    aliquotaIcms = table.Column<double>(type: "double precision", nullable: true),
                    coeficienteNormal = table.Column<double>(type: "double precision", nullable: true),
                    coeficienteLei2826 = table.Column<double>(type: "double precision", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZFMTributacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZFMUtilizacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZFMUtilizacao", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcordoAladi");

            migrationBuilder.DropTable(
                name: "CoberturaCambial");

            migrationBuilder.DropTable(
                name: "FundamentoLegal");

            migrationBuilder.DropTable(
                name: "ModalidadePagamento");

            migrationBuilder.DropTable(
                name: "Moeda");

            migrationBuilder.DropTable(
                name: "MotivoSemCobertura_cambial");

            migrationBuilder.DropTable(
                name: "RegimeTributavel");

            migrationBuilder.DropTable(
                name: "TipoAcordoTarifario");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "ZFMAplicacaoMaterial");

            migrationBuilder.DropTable(
                name: "ZFMDestinacao");

            migrationBuilder.DropTable(
                name: "ZFMTributacao");

            migrationBuilder.DropTable(
                name: "ZFMUtilizacao");
        }
    }
}
