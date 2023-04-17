using CasteloChurch.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasteloChurch.Domain.Interfaces
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
