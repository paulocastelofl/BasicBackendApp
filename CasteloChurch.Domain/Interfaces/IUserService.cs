using CasteloChurch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasteloChurch.Domain.Interfaces
{
    public interface IUserService
    {
        User Add(User obj);

    }
}
