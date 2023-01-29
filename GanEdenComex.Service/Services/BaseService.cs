using FluentValidation;
using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public TEntity Add(TEntity obj)
        {
            _baseRepository.Insert(obj);
            return obj;
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public IList<TEntity> Get()
        {
            return _baseRepository.Select();
        }

        public TEntity GetById(int id)
        {
           return _baseRepository.Select(id);
        }

        public TEntity Update(TEntity obj)
        {
            _baseRepository.Update(obj);
            return obj;
        }
    }
}
