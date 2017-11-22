using System.Collections.Generic;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Repository;
using Dapper.Contrib.Extensions;
using PersonalFinance.Infra.Data.Interfaces;
using System;

namespace PersonalFinance.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
            where TEntity : EntityBase
    {
        protected readonly IContext _context;
        public RepositoryBase(IContext context)
        {
            _context = context;
        }

        public int Add(TEntity entity)
        {
            return Convert.ToInt32(_context.Connection.Insert<TEntity>(entity));
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Connection.GetAll<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _context.Connection.Get<TEntity>(id);
        }

        public void Remove(TEntity entity)
        {
            _context.Connection.Delete<TEntity>(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Connection.Update<TEntity>(entity);
        }
    }
}