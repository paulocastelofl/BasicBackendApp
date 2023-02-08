using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using GanEdenComex.Infra.CrossCutting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _baseRepository;

        public UserService(IBaseRepository<User> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public User Add(User obj)
        {
            var encryptDecrypt = new EncryptDecrypt();
            obj.Password = encryptDecrypt?.EncryptString(obj.Password!);

            _baseRepository.Insert(obj);
            return new User
            {
                Id = obj.Id,
                Name = obj.Name,
                Email = obj.Email
            };
        }

        public IList<User> GetByEmpresa(int id)
        {
            return _baseRepository.Select().Where(x => x.IdEmpresa == id).ToList();
        }
    }
}
