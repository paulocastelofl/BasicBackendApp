﻿// <auto-generated />
using System;
using GanEdenComex.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GanEdenComex.Infra.Data.Migrations
{
    [DbContext(typeof(PostgresContext))]
    partial class PostgresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GanEdenComex.Domain.Entities.AcordoAladi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AcordoAladi");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.AtividadeEconomica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int?>("Ordem")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("AtividadeEconomica");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.CertificadoDigital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Arquivo_CertificadoDigital")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DT_Vencimento_CertificadoDigital")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Senha_CerficadoDigital")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CertificadoDigital");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.CoberturaCambial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CoberturaCambial");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("AprovaRegistroDI")
                        .HasColumnType("boolean");

                    b.Property<string>("AtividadeEconomica")
                        .HasColumnType("text");

                    b.Property<bool?>("AtualizarFornecedoresFabricantes")
                        .HasColumnType("boolean");

                    b.Property<bool?>("AtualizarItens")
                        .HasColumnType("boolean");

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .HasColumnType("text");

                    b.Property<string>("CNAE")
                        .HasColumnType("text");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<bool?>("CadastroDeFornecedoresFabricantes")
                        .HasColumnType("boolean");

                    b.Property<bool?>("CadastroDeItens")
                        .HasColumnType("boolean");

                    b.Property<string>("CentroDeCusto")
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<bool?>("ControlarCEMercantes")
                        .HasColumnType("boolean");

                    b.Property<bool?>("ControlarCambio")
                        .HasColumnType("boolean");

                    b.Property<bool?>("ControlarDemurrage")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Despachante")
                        .HasColumnType("boolean");

                    b.Property<string>("DespachantePadrao")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<bool?>("Exportador")
                        .HasColumnType("boolean");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("integer");

                    b.Property<int?>("IdPais")
                        .HasColumnType("integer");

                    b.Property<bool?>("Importador")
                        .HasColumnType("boolean");

                    b.Property<string>("InscricaoMunicipal")
                        .HasColumnType("text");

                    b.Property<string>("InscricaoSuframa")
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("NumeroDeCadastroNoMA")
                        .HasColumnType("text");

                    b.Property<int?>("PrazoDiasCEMercanteCritico")
                        .HasColumnType("integer");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text");

                    b.Property<bool?>("Segurado")
                        .HasColumnType("boolean");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdPais");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Fabricante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<int?>("IdPais")
                        .HasColumnType("integer");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("Nome_Fabricante")
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("Tipo_Fabricante")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdPais");

                    b.ToTable("Fabricante");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .HasColumnType("text");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("CodigoInterno")
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("integer");

                    b.Property<int?>("IdPais")
                        .HasColumnType("integer");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdPais");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.FundamentoLegal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FundamentoLegal");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Incoterms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("freteEmbutido")
                        .HasColumnType("boolean");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<bool?>("seguroEmbutido")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Incoterms");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.InscricaoEstadual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("integer");

                    b.Property<string>("Inscricao")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("InscricaoEstadual");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CodigoInterno")
                        .HasColumnType("integer");

                    b.Property<string>("DescricaoDetalhada")
                        .HasColumnType("text");

                    b.Property<string>("DescricaoNFE")
                        .HasColumnType("text");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("integer");

                    b.Property<int?>("IdFornecedor")
                        .HasColumnType("integer");

                    b.Property<int?>("IdNCM")
                        .HasColumnType("integer");

                    b.Property<string>("PartNumber")
                        .HasColumnType("text");

                    b.Property<string>("UnidadeOrganizacional")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdFornecedor");

                    b.HasIndex("IdNCM");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.ModalidadePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<int?>("ordem")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ModalidadePagamento");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Moeda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Moeda");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.MotivoSemCobertura_cambial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MotivoSemCobertura_cambial");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.NCM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ano")
                        .HasColumnType("text");

                    b.Property<string>("Ato_Legal")
                        .HasColumnType("text");

                    b.Property<string>("Codigo_NCM")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Data_Fim")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Data_Inicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("Descricao_Concatenada")
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NCM");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo_Pais")
                        .HasColumnType("text");

                    b.Property<string>("Nome_Pais")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdFabricante")
                        .HasColumnType("integer");

                    b.Property<int?>("IdNCM")
                        .HasColumnType("integer");

                    b.Property<string>("Nome_Produto")
                        .HasColumnType("text");

                    b.Property<double?>("Peso")
                        .HasColumnType("double precision");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<string>("Tipo_De_Emabalagem")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdFabricante");

                    b.HasIndex("IdNCM");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.RegimeTributavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RegimeTributavel");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.RegistroAcesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Dt_E_Hora_Ultimo_Acesso")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Processo_Ultimo_Acesso")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RegistroAcesso");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.RepresentanteLegal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .HasColumnType("text");

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<int?>("IdCertificadoDigital")
                        .HasColumnType("integer");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("integer");

                    b.Property<string>("MarinhaMercante")
                        .HasColumnType("text");

                    b.Property<string>("RegistroRepresentante")
                        .HasColumnType("text");

                    b.Property<string>("SenhaSISCOMEX")
                        .HasColumnType("text");

                    b.Property<string>("SenhaSUFRAMA")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdCertificadoDigital");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("RepresentanteLegal");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.TipoAcordoTarifario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TipoAcordoTarifario");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Unidade");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.ZFMAplicacaoMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ZFMAplicacaoMaterial");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.ZFMDestinacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ZFMDestinacao");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.ZFMTributacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double?>("aliquotaIcms")
                        .HasColumnType("double precision");

                    b.Property<double?>("aliquotaMva")
                        .HasColumnType("double precision");

                    b.Property<double?>("aliquotaReducao")
                        .HasColumnType("double precision");

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<double?>("coeficienteLei2826")
                        .HasColumnType("double precision");

                    b.Property<double?>("coeficienteNormal")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ZFMTributacao");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.ZFMUtilizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("dtModificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ZFMUtilizacao");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Empresa", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.Empresa", null)
                        .WithMany("Associados")
                        .HasForeignKey("IdEmpresa");

                    b.HasOne("GanEdenComex.Domain.Entities.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("IdPais");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Fabricante", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("IdPais");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Fornecedor", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa");

                    b.HasOne("GanEdenComex.Domain.Entities.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("IdPais");

                    b.Navigation("Empresa");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.InscricaoEstadual", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Item", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa");

                    b.HasOne("GanEdenComex.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("IdFornecedor");

                    b.HasOne("GanEdenComex.Domain.Entities.NCM", "NCM")
                        .WithMany()
                        .HasForeignKey("IdNCM");

                    b.Navigation("Empresa");

                    b.Navigation("Fornecedor");

                    b.Navigation("NCM");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Produto", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.Fabricante", "Fabricante")
                        .WithMany()
                        .HasForeignKey("IdFabricante");

                    b.HasOne("GanEdenComex.Domain.Entities.NCM", "NCM")
                        .WithMany()
                        .HasForeignKey("IdNCM");

                    b.Navigation("Fabricante");

                    b.Navigation("NCM");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.RegistroAcesso", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.RepresentanteLegal", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.CertificadoDigital", "CertificadoDigital")
                        .WithMany()
                        .HasForeignKey("IdCertificadoDigital");

                    b.HasOne("GanEdenComex.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa");

                    b.Navigation("CertificadoDigital");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.User", b =>
                {
                    b.HasOne("GanEdenComex.Domain.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GanEdenComex.Domain.Entities.Empresa", b =>
                {
                    b.Navigation("Associados");
                });
#pragma warning restore 612, 618
        }
    }
}
