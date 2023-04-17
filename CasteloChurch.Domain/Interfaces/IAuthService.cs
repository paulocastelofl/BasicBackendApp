using CasteloChurch.Domain.DTO;
using CasteloChurch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasteloChurch.Domain.Interfaces
{
    public interface IAuthService
    {
        public dynamic Login(AuthLoginDTO model);
    }
}
