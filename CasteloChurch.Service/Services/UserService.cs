using CasteloChurch.Domain.Entities;
using CasteloChurch.Domain.Interfaces;
using CasteloChurch.Infra.CrossCutting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CasteloChurch.Service.Services
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

    }
}
