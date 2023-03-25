using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using GanEdenComex.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace GanEdenComex.Infra.Data.Context
{
    public class PostgresContext : DbContext
    {
        private readonly IEncryptionProvider _provider;
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
        {
            this._provider = new GenerateEncryptionProvider("example_encrypt_key");

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<RegistroAcesso> RegistroAcesso { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Fabricante> Fabricante { get; set; }
        public virtual DbSet<Pais> Pais {get; set; }
        public virtual DbSet<Empresa> Empresa {get; set; }
        public virtual DbSet<Ncm> Ncm {get; set; }
        public virtual DbSet<Fornecedor> Fornecedor {get; set; }
        public virtual DbSet<InscricaoEstadual> InscricaoEstadual {get; set; }
        public virtual DbSet<RepresentanteLegal> RepresentanteLegal {get; set; }
        public virtual DbSet<CertificadoDigital> CertificadoDigital {get; set; }
        public virtual DbSet<Item> Item {get; set; }
        public virtual DbSet<AtividadeEconomica> AtividadeEconomica { get; set; }
        public virtual DbSet<Incoterms> Incoterms { get; set; }
        public virtual DbSet<CoberturaCambial> CoberturaCambial { get; set; }
        public virtual DbSet<MotivoSemCobertura_cambial> MotivoSemCobertura_cambial { get; set; }
        public virtual DbSet<ZFMDestinacao> ZFMDestinacao { get; set; }
        public virtual DbSet<ZFMTributacao> ZFMTributacao { get; set; }
        public virtual DbSet<ZFMUtilizacao> ZFMUtilizacao { get; set; }
        public virtual DbSet<ZFMAplicacaoMaterial> ZFMAplicacaoMaterial { get; set; }
        public virtual DbSet<RegimeTributavel> RegimeTributavel { get; set; }
        public virtual DbSet<FundamentoLegal> FundamentoLegal { get; set; }
        public virtual DbSet<ModalidadePagamento> ModalidadePagamento { get; set; }
        public virtual DbSet<Moeda> Moeda { get; set; }
        public virtual DbSet<TipoAcordoTarifario> TipoAcordoTarifario { get; set; }
        public virtual DbSet<AcordoAladi> AcordoAladi { get; set; }
        public virtual DbSet<Unidade> Unidade { get; set; }
        public virtual DbSet<Capitulo> Capitulo {get; set; }
        public virtual DbSet<Transportador> Transportador { get; set; }
        public virtual DbSet<Agente> Agente { get; set; }
        public virtual DbSet<AtoLegal> AtoLegal { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<TipoDocumentos> TipoDocumentos { get; set; }
        public virtual DbSet<Naladi> Naladi { get; set; }
        public virtual DbSet<ExTarifario> ExTarifario { get; set; }
        public virtual DbSet<ExTIPI> ExTIPI { get; set; }
        public virtual DbSet<TipoFornecedor> TipoFornecedor { get; set; }
        public virtual DbSet<Credenciais> Credenciais { get; set; }
        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<ProdutoSuframa> ProdutoSuframa { get; set; }
        public virtual DbSet<TipoProduto> TipoProduto { get; set; }
        public virtual DbSet<Modal> Modal { get; set; }
        public virtual DbSet<Urf> Urf { get; set; }
        public virtual DbSet<ZFM> ZFM { get; set; }
        public virtual DbSet<Destinacao> Destinacao { get; set; }
        public virtual DbSet<Utilizacao> Utilizacao { get; set; }
        public virtual DbSet<Tributacao> Tributacao { get; set; }
        public virtual DbSet<TipoDocumentoTributacao> TipoDocumentoTributacao { get; set; }
        public virtual DbSet<ProdutoSuframaNcm> ProdutoSuframaNcm { get; set; }
        public virtual DbSet<MatrizTributacao> MatrizTributacao { get; set; }
        public virtual DbSet<TipoDeclaracao> TipoDeclaracao { get; set; }
        public virtual DbSet<ProcessoImportacao> ProcessoImportacao { get; set; }
        public virtual DbSet<TipoUser> TipoUser { get; set; }
        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<ItemFatura> ItemFatura { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.UseEncryption(this._provider);
            modelBuilder.Entity<User>();
            modelBuilder.Entity<RegistroAcesso>();
            modelBuilder.Entity<Produto>();
            modelBuilder.Entity<Fabricante>();
            modelBuilder.Entity<Pais>();
            modelBuilder.Entity<Empresa>()
            .HasMany(b => b.Associados)
            .WithOne().HasForeignKey(b => b.IdEmpresa);

            modelBuilder.Entity<Capitulo>();
            modelBuilder.Entity<Ncm>();
            modelBuilder.Entity<Fornecedor>();
            modelBuilder.Entity<InscricaoEstadual>();
            modelBuilder.Entity<RepresentanteLegal>();
            modelBuilder.Entity<CertificadoDigital>();
            modelBuilder.Entity<Item>();
            modelBuilder.Entity<Transportador>();
            modelBuilder.Entity<Agente>();
            modelBuilder.Entity<AtoLegal>();
            modelBuilder.Entity<Documentos>();
            modelBuilder.Entity<TipoDocumentos>();
            modelBuilder.Entity<Naladi>();
            modelBuilder.Entity<ExTarifario>();
            modelBuilder.Entity<ExTIPI>();
            modelBuilder.Entity<TipoFornecedor>();
            modelBuilder.Entity<Credenciais>();
            modelBuilder.Entity<Conta>();
            modelBuilder.Entity<ProdutoSuframa>();
            modelBuilder.Entity<TipoProduto>();
            modelBuilder.Entity<Modal>();
            modelBuilder.Entity<Urf>();
            modelBuilder.Entity<ZFM>();
            modelBuilder.Entity<Destinacao>();
            modelBuilder.Entity<Utilizacao>();
            modelBuilder.Entity<Tributacao>();
            modelBuilder.Entity<TipoDocumentoTributacao>();
            modelBuilder.Entity<ProdutoSuframaNcm>();
            modelBuilder.Entity<MatrizTributacao>();
            modelBuilder.Entity<TipoDeclaracao>();
            modelBuilder.Entity<ProcessoImportacao>();
            modelBuilder.Entity<TipoUser>();
            modelBuilder.Entity<Fatura>();
            modelBuilder.Entity<ItemFatura>();
        }


    }

    /* Comands Migration
     
         dotnet ef migrations add AtividadeEconomica --project .\GanEdenComex.Infra.Data --startup-project .\GanEdenComex.Application

        dotnet ef database update --project .\GanEdenComex.Infra.Data --startup-project .\GanEdenComex.Application

    */
}
