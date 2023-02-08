using GanEdenComex.Domain.DTO;
using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using GanEdenComex.Infra.CrossCutting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GanEdenComex.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IBaseRepository<User> _baseRepository;
        private readonly IConfiguration _configuration;

        public AuthService(IBaseRepository<User> baseRepository, IConfiguration configuration)
        {
            _baseRepository = baseRepository;
            _configuration = configuration;
        }
        public dynamic Login(AuthLoginDTO model)
        {
            var encryptDecrypt = new EncryptDecrypt();

            User? user = _baseRepository.Select().Where(u => u.Email!.ToLower().Equals(model?.Email?.ToLower())).FirstOrDefault();

            if (user == null) throw new Exception("Usuário ou Senha inválida", new HttpResponseException(HttpStatusCode.Forbidden));

            if (!user!.Password!.Equals(encryptDecrypt.EncryptString(model.Password!))) throw new Exception("Usuário ou Senha inválida", new HttpResponseException(HttpStatusCode.Forbidden));

            var mangerJwtService = new MangerJwtService();
            var token = mangerJwtService.GenerateToken(user);

            user.Password = string.Empty;

            return new
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                IdEmpresa = user.IdEmpresa,
                Token = token
            };
        }

    }
}
