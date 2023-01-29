using FluentValidation;
using GanEdenComex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity obj);

        void Delete(int id);

        IList<TEntity> Get();

        TEntity GetById(int id);

        TEntity Update(TEntity obj);
    }
}
