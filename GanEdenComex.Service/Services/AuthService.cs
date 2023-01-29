using GanEdenComex.Domain.DTO;
using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GanEdenComex.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IBaseRepository<User> _baseRepository;

        public AuthService(IBaseRepository<User> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public User Login(AuthLoginDTO model)
        {
            User? user = _baseRepository.Select().Where(u => u.Email!.ToLower().Equals(model?.Email?.ToLower())).FirstOrDefault();

            if (user == null) throw new Exception("Usuário ou Senha inválida", new HttpResponseException(HttpStatusCode.Forbidden));
            if (!user!.Password!.Equals(model.Password)) throw new Exception("Usuário ou Senha inválida", new HttpResponseException(HttpStatusCode.Forbidden));

            user.Password = string.Empty;

            return user;
        }
    }
}
