using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using GanEdenComex.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.UseEncryption(this._provider);
            modelBuilder.Entity<User>();
            modelBuilder.Entity<RegistroAcesso>();
            modelBuilder.Entity<Produto>();
            modelBuilder.Entity<Fabricante>();
        }


    }

    /* Comands Migration
     
         dotnet ef migrations add InitialCreate_2 --project .\GanEdenComex.Infra.Data --startup-project .\GanEdenComex.Application

        dotnet ef database update --project .\GanEdenComex.Infra.Data --startup-project .\GanEdenComex.Application

    */
}
