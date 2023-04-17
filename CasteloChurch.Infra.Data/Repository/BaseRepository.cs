using CasteloChurch.Domain.Entities;
using CasteloChurch.Domain.Interfaces;
using CasteloChurch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasteloChurch.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly PostgresContext _postgresctx;
        public BaseRepository(PostgresContext postgresctx)
        {
            _postgresctx = postgresctx;
        }
        public void Delete(int id)
        {
            _postgresctx.Set<TEntity>().Remove(Select(id));
            _postgresctx.SaveChanges();
        }

        public void Insert(TEntity obj)
        {
            _postgresctx.Set<TEntity>().Add(obj);
            _postgresctx.SaveChanges();
        }

        public IList<TEntity> Select() => _postgresctx.Set<TEntity>().ToList();

        public TEntity Select(int id) => _postgresctx.Set<TEntity>().Find(id);

        public void Update(TEntity obj)
        {
            _postgresctx.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _postgresctx.SaveChanges();
        }
    }
}
