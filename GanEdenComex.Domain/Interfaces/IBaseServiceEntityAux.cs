using GanEdenComex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Interfaces
{
    public interface IBaseServiceEntityAux
    {
        IList<BaseEntityAux> GetBySearch(string q);
    }
}
