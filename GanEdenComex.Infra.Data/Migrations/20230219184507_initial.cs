using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                name: "AtividadeEconomica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ordem = table.Column<int>(type: "integer", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadeEconomica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificadoDigital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArquivoCertificadoDigital = table.Column<string>(name: "Arquivo_CertificadoDigital", type: "text", nullable: true),
                    SenhaCerficadoDigital = table.Column<string>(name: "Senha_CerficadoDigital", type: "text", nullable: true),
                    DTVencimentoCertificadoDigital = table.Column<DateTime>(name: "DT_Vencimento_CertificadoDigital", type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificadoDigital", x => x.Id);
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
                name: "ExTarifario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    orgao = table.Column<string>(type: "text", nullable: true),
                    ato = table.Column<string>(type: "text", nullable: true),
                    ano = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExTarifario", x => x.Id);
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
                name: "Incoterms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    freteEmbutido = table.Column<bool>(type: "boolean", nullable: true),
                    seguroEmbutido = table.Column<bool>(type: "boolean", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incoterms", x => x.Id);
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
                name: "Naladi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    ordem = table.Column<int>(type: "integer", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naladi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoPais = table.Column<string>(name: "Codigo_Pais", type: "text", nullable: true),
                    NomePais = table.Column<string>(name: "Nome_Pais", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CNPJ = table.Column<string>(type: "text", nullable: true),
                    RazaoSocial = table.Column<string>(type: "text", nullable: true),
                    NomeFantasia = table.Column<string>(type: "text", nullable: true),
                    Logradouro = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Complemento = table.Column<string>(type: "text", nullable: true),
                    Bairro = table.Column<string>(type: "text", nullable: true),
                    CEP = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    InscricaoMunicipal = table.Column<string>(type: "text", nullable: true),
                    Despachante = table.Column<bool>(type: "boolean", nullable: true),
                    Importador = table.Column<bool>(type: "boolean", nullable: true),
                    Exportador = table.Column<bool>(type: "boolean", nullable: true),
                    InscricaoSuframa = table.Column<string>(type: "text", nullable: true),
                    IdPais = table.Column<int>(type: "integer", nullable: true),
                    AprovaRegistroDI = table.Column<bool>(type: "boolean", nullable: true),
                    IdAtividadeEconomica = table.Column<int>(type: "integer", nullable: true),
                    CNAE = table.Column<string>(type: "text", nullable: true),
                    NumeroDeCadastroNoMA = table.Column<string>(type: "text", nullable: true),
                    LimiteDeValorFOB = table.Column<double>(type: "double precision", nullable: true),
                    DespachantePadrao = table.Column<string>(type: "text", nullable: true),
                    PrazoDiasCEMercanteCritico = table.Column<int>(type: "integer", nullable: true),
                    CentroDeCusto = table.Column<string>(type: "text", nullable: true),
                    CadastroDeItens = table.Column<bool>(type: "boolean", nullable: true),
                    AtualizarItens = table.Column<bool>(type: "boolean", nullable: true),
                    CadastroDeFornecedoresFabricantes = table.Column<bool>(type: "boolean", nullable: true),
                    AtualizarFornecedoresFabricantes = table.Column<bool>(type: "boolean", nullable: true),
                    ControlarDemurrage = table.Column<bool>(type: "boolean", nullable: true),
                    ControlarCEMercantes = table.Column<bool>(type: "boolean", nullable: true),
                    ControlarCambio = table.Column<bool>(type: "boolean", nullable: true),
                    Segurado = table.Column<bool>(type: "boolean", nullable: true),
                    NumeroSequencialFIEAM = table.Column<int>(type: "integer", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_AtividadeEconomica_IdAtividadeEconomica",
                        column: x => x.IdAtividadeEconomica,
                        principalTable: "AtividadeEconomica",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Empresa_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Empresa_Pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeFabricante = table.Column<string>(name: "Nome_Fabricante", type: "text", nullable: true),
                    TipoFabricante = table.Column<string>(name: "Tipo_Fabricante", type: "text", nullable: true),
                    Logradouro = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Complemento = table.Column<string>(type: "text", nullable: true),
                    Bairro = table.Column<string>(type: "text", nullable: true),
                    CEP = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    IdPais = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fabricante_Pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ncm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IdUnidade = table.Column<int>(type: "integer", nullable: true),
                    unidadeId = table.Column<int>(type: "integer", nullable: true),
                    vlIi = table.Column<double>(type: "double precision", nullable: true),
                    vlIiMercosul = table.Column<double>(type: "double precision", nullable: true),
                    vlIpi = table.Column<double>(type: "double precision", nullable: true),
                    vlPis = table.Column<double>(type: "double precision", nullable: true),
                    vlCofins = table.Column<double>(type: "double precision", nullable: true),
                    dtAtualizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    codigo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ncm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ncm_Unidade_unidadeId",
                        column: x => x.unidadeId,
                        principalTable: "Unidade",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Agente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RazaoSocial = table.Column<string>(type: "text", nullable: true),
                    NomeFantasia = table.Column<string>(type: "text", nullable: true),
                    Logradouro = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Complemento = table.Column<string>(type: "text", nullable: true),
                    Bairro = table.Column<string>(type: "text", nullable: true),
                    CEP = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    InscricaoEstadual = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true),
                    IdPais = table.Column<int>(type: "integer", nullable: true),
                    NIF = table.Column<string>(type: "text", nullable: true),
                    CodigoInterno = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agente_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Agente_Pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CaminhoDocumento = table.Column<string>(type: "text", nullable: true),
                    TipoDocumento = table.Column<string>(type: "text", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "text", nullable: true),
                    DataVencimentoDocumento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CNPJ = table.Column<string>(type: "text", nullable: true),
                    RazaoSocial = table.Column<string>(type: "text", nullable: true),
                    NomeFantasia = table.Column<string>(type: "text", nullable: true),
                    Logradouro = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Complemento = table.Column<string>(type: "text", nullable: true),
                    Bairro = table.Column<string>(type: "text", nullable: true),
                    CEP = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true),
                    IdPais = table.Column<int>(type: "integer", nullable: true),
                    TipoDeVinculo = table.Column<string>(type: "text", nullable: true),
                    CodigoInterno = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fornecedor_Pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InscricaoEstadual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Inscricao = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscricaoEstadual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InscricaoEstadual_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RepresentanteLegal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CPF = table.Column<string>(type: "text", nullable: true),
                    CNPJ = table.Column<string>(type: "text", nullable: true),
                    MarinhaMercante = table.Column<string>(type: "text", nullable: true),
                    RegistroRepresentante = table.Column<string>(type: "text", nullable: true),
                    SenhaSISCOMEX = table.Column<string>(type: "text", nullable: true),
                    SenhaSUFRAMA = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true),
                    IdCertificadoDigital = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentanteLegal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepresentanteLegal_CertificadoDigital_IdCertificadoDigital",
                        column: x => x.IdCertificadoDigital,
                        principalTable: "CertificadoDigital",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RepresentanteLegal_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transportador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CNPJ = table.Column<string>(type: "text", nullable: true),
                    RazaoSocial = table.Column<string>(type: "text", nullable: true),
                    NomeFantasia = table.Column<string>(type: "text", nullable: true),
                    Logradouro = table.Column<string>(type: "text", nullable: true),
                    Numero = table.Column<string>(type: "text", nullable: true),
                    Complemento = table.Column<string>(type: "text", nullable: true),
                    Bairro = table.Column<string>(type: "text", nullable: true),
                    CEP = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    InscricaoEstadual = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true),
                    IdPais = table.Column<int>(type: "integer", nullable: true),
                    CodigoInterno = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transportador_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transportador_Pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Cpf = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeProduto = table.Column<string>(name: "Nome_Produto", type: "text", nullable: true),
                    Quantidade = table.Column<int>(type: "integer", nullable: true),
                    Peso = table.Column<double>(type: "double precision", nullable: true),
                    TipoDeEmbalagem = table.Column<string>(name: "Tipo_De_Embalagem", type: "text", nullable: true),
                    IdFabricante = table.Column<int>(type: "integer", nullable: true),
                    IdNCM = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Fabricante_IdFabricante",
                        column: x => x.IdFabricante,
                        principalTable: "Fabricante",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produto_Ncm_IdNCM",
                        column: x => x.IdNCM,
                        principalTable: "Ncm",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeTipoDocumento = table.Column<string>(type: "text", nullable: true),
                    TipoSiscomexDocumento = table.Column<string>(type: "text", nullable: true),
                    IdDocumentos = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoDocumentos_Documentos_IdDocumentos",
                        column: x => x.IdDocumentos,
                        principalTable: "Documentos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartNumber = table.Column<string>(type: "text", nullable: true),
                    partNumberInterno = table.Column<string>(type: "text", nullable: true),
                    DescricaoDetalhada = table.Column<string>(type: "text", nullable: true),
                    IdFornecedor = table.Column<int>(type: "integer", nullable: true),
                    IdNCM = table.Column<int>(type: "integer", nullable: true),
                    IdUnidade = table.Column<int>(type: "integer", nullable: true),
                    unidadeId = table.Column<int>(type: "integer", nullable: true),
                    DescricaoNFE = table.Column<string>(type: "text", nullable: true),
                    detalheNcm = table.Column<string>(type: "text", nullable: true),
                    ProdutoSuframa = table.Column<string>(type: "text", nullable: true),
                    DescricaoProdutoSuframa = table.Column<string>(type: "text", nullable: true),
                    tipoProduto = table.Column<string>(type: "text", nullable: true),
                    tratamentoAdministrativo = table.Column<string>(type: "text", nullable: true),
                    vlCra = table.Column<double>(type: "double precision", nullable: true),
                    AliquotaII = table.Column<double>(type: "double precision", nullable: true),
                    AliquotaIPI = table.Column<double>(type: "double precision", nullable: true),
                    AliquotaPIS = table.Column<double>(type: "double precision", nullable: true),
                    AliquotaCOFINS = table.Column<double>(type: "double precision", nullable: true),
                    UnidadeOrganizacional = table.Column<string>(type: "text", nullable: true),
                    dtModificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IdEmpresa = table.Column<int>(type: "integer", nullable: true),
                    IdNaladi = table.Column<int>(type: "integer", nullable: true),
                    naladiId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Fornecedor_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Naladi_naladiId",
                        column: x => x.naladiId,
                        principalTable: "Naladi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Ncm_IdNCM",
                        column: x => x.IdNCM,
                        principalTable: "Ncm",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Unidade_unidadeId",
                        column: x => x.unidadeId,
                        principalTable: "Unidade",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RegistroAcesso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    DtEHoraUltimoAcesso = table.Column<DateTime>(name: "Dt_E_Hora_Ultimo_Acesso", type: "timestamp with time zone", nullable: true),
                    ProcessoUltimoAcesso = table.Column<string>(name: "Processo_Ultimo_Acesso", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroAcesso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroAcesso_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agente_IdEmpresa",
                table: "Agente",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Agente_IdPais",
                table: "Agente",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_AtoLegal_IdEmpresa",
                table: "AtoLegal",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_IdEmpresa",
                table: "Documentos",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdAtividadeEconomica",
                table: "Empresa",
                column: "IdAtividadeEconomica");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdEmpresa",
                table: "Empresa",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdPais",
                table: "Empresa",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Fabricante_IdPais",
                table: "Fabricante",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_IdEmpresa",
                table: "Fornecedor",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_IdPais",
                table: "Fornecedor",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_InscricaoEstadual_IdEmpresa",
                table: "InscricaoEstadual",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdEmpresa",
                table: "Item",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdFornecedor",
                table: "Item",
                column: "IdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdNCM",
                table: "Item",
                column: "IdNCM");

            migrationBuilder.CreateIndex(
                name: "IX_Item_naladiId",
                table: "Item",
                column: "naladiId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_unidadeId",
                table: "Item",
                column: "unidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ncm_unidadeId",
                table: "Ncm",
                column: "unidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdFabricante",
                table: "Produto",
                column: "IdFabricante");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdNCM",
                table: "Produto",
                column: "IdNCM");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroAcesso_UserId",
                table: "RegistroAcesso",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RepresentanteLegal_IdCertificadoDigital",
                table: "RepresentanteLegal",
                column: "IdCertificadoDigital");

            migrationBuilder.CreateIndex(
                name: "IX_RepresentanteLegal_IdEmpresa",
                table: "RepresentanteLegal",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_TipoDocumentos_IdDocumentos",
                table: "TipoDocumentos",
                column: "IdDocumentos");

            migrationBuilder.CreateIndex(
                name: "IX_Transportador_IdEmpresa",
                table: "Transportador",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Transportador_IdPais",
                table: "Transportador",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdEmpresa",
                table: "Users",
                column: "IdEmpresa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcordoAladi");

            migrationBuilder.DropTable(
                name: "Agente");

            migrationBuilder.DropTable(
                name: "AtoLegal");

            migrationBuilder.DropTable(
                name: "CoberturaCambial");

            migrationBuilder.DropTable(
                name: "ExTarifario");

            migrationBuilder.DropTable(
                name: "FundamentoLegal");

            migrationBuilder.DropTable(
                name: "Incoterms");

            migrationBuilder.DropTable(
                name: "InscricaoEstadual");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "ModalidadePagamento");

            migrationBuilder.DropTable(
                name: "Moeda");

            migrationBuilder.DropTable(
                name: "MotivoSemCobertura_cambial");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "RegimeTributavel");

            migrationBuilder.DropTable(
                name: "RegistroAcesso");

            migrationBuilder.DropTable(
                name: "RepresentanteLegal");

            migrationBuilder.DropTable(
                name: "TipoAcordoTarifario");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");

            migrationBuilder.DropTable(
                name: "Transportador");

            migrationBuilder.DropTable(
                name: "ZFMAplicacaoMaterial");

            migrationBuilder.DropTable(
                name: "ZFMDestinacao");

            migrationBuilder.DropTable(
                name: "ZFMTributacao");

            migrationBuilder.DropTable(
                name: "ZFMUtilizacao");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Naladi");

            migrationBuilder.DropTable(
                name: "Fabricante");

            migrationBuilder.DropTable(
                name: "Ncm");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CertificadoDigital");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "AtividadeEconomica");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
