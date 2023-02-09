

using GanEdenComex.Application.Middlewares;
using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using GanEdenComex.Infra.Data.Context;
using GanEdenComex.Infra.Data.Repository;
using GanEdenComex.Service.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

var key = Encoding.ASCII.GetBytes("fedaf7d8863b48e197b9287d492b708e");

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ClockSkew = TimeSpan.Zero
    };

});

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
          new OpenApiSecurityScheme
          {
            Reference = new OpenApiReference
              {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
              },
              Scheme = "oauth2",
              Name = "Bearer",
              In = ParameterLocation.Header,

            },
            Array.Empty<string>()
         }

    });
});

builder.Services.AddDbContext<PostgresContext>(options =>
{   
    options
    .UseLazyLoadingProxies()
    .UseNpgsql(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
builder.Services.AddScoped<IBaseService<User>, BaseService<User>>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
builder.Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();

builder.Services.AddScoped<IBaseRepository<Fabricante>, BaseRepository<Fabricante>>();
builder.Services.AddScoped<IBaseService<Fabricante>, BaseService<Fabricante>>();

builder.Services.AddScoped<IBaseRepository<Empresa>, BaseRepository<Empresa>>();
builder.Services.AddScoped<IBaseService<Empresa>, BaseService<Empresa>>();
builder.Services.AddScoped<IEmpresaService, EmpresaService>();


builder.Services.AddScoped<IBaseRepository<NCM>, BaseRepository<NCM>>();
builder.Services.AddScoped<IBaseService<NCM>, BaseService<NCM>>();

builder.Services.AddScoped<IBaseRepository<Pais>, BaseRepository<Pais>>();
builder.Services.AddScoped<IBaseService<Pais>, BaseService<Pais>>();

builder.Services.AddScoped<IBaseRepository<Fornecedor>, BaseRepository<Fornecedor>>();
builder.Services.AddScoped<IBaseService<Fornecedor>, BaseService<Fornecedor>>();

builder.Services.AddScoped<IBaseRepository<InscricaoEstadual>, BaseRepository<InscricaoEstadual>>();
builder.Services.AddScoped<IBaseService<InscricaoEstadual>, BaseService<InscricaoEstadual>>();

builder.Services.AddScoped<IBaseRepository<RepresentanteLegal>, BaseRepository<RepresentanteLegal>>();
builder.Services.AddScoped<IBaseService<RepresentanteLegal>, BaseService<RepresentanteLegal>>();

builder.Services.AddScoped<IBaseRepository<CertificadoDigital>, BaseRepository<CertificadoDigital>>();
builder.Services.AddScoped<IBaseService<CertificadoDigital>, BaseService<CertificadoDigital>>();

builder.Services.AddScoped<IBaseRepository<Item>, BaseRepository<Item>>();
builder.Services.AddScoped<IBaseService<Item>, BaseService<Item>>();

builder.Services.AddScoped<IAuthService, AuthService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod());


app.UseAuthentication();
app.UseAuthorization();

app.ConfigureExtensionHandler();

app.MapControllers();

app.Run();
