using System;
using System.Collections.Generic;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        int Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}