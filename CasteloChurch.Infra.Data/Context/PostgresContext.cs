using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using CasteloChurch.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace CasteloChurch.Infra.Data.Context
{
    public class PostgresContext : DbContext
    {
        private readonly IEncryptionProvider _provider;
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
        {
            _provider = new GenerateEncryptionProvider("example_encrypt_key");

        }

        public virtual DbSet<User> Users { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.UseEncryption(_provider);
            modelBuilder.Entity<User>();
          
        }


    }

    /* Comands Migration
     
         dotnet ef migrations add AtividadeEconomica --project .\CasteloChurch.Infra.Data --startup-project .\CasteloChurch.Application

        dotnet ef database update --project .\CasteloChurch.Infra.Data --startup-project .\CasteloChurch.Application

     dotnet ef migrations remove --project .\CasteloChurch.Infra.Data --startup-project .\CasteloChurch.Application

    */
}
