using System;
using System.Collections.Generic;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Repository;
using PersonalFinance.Domain.Interfaces.Services;
using PersonalFinance.Domain.Interfaces.UnitOfWork;
using PersonalFinance.Domain.Interfaces.Validates;

namespace PersonalFinance.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> 
        where TEntity : EntityBase, new()
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private readonly IValidateBase<TEntity> _validate;

        public ServiceBase(IRepositoryBase<TEntity> repository, IValidateBase<TEntity> validate)
        {
            _repository = repository;
            _validate = validate;            
        }
        public TEntity Add(TEntity entity)
        {
            if (!_validate.AddValidate(entity))
                return new TEntity();

            entity.Id = _repository.Add(entity);
            return entity;
        }

        public IEnumerable<TEntity> GetAll() => _repository.GetAll();

        public TEntity GetById(int id) => _repository.GetById(id);

        public void Remove(TEntity entity) => _repository.Remove(entity);

        public void Update(TEntity entity)
        {
            if (!_validate.UpdateValidate(entity))
                return;
            _repository.Update(entity);
        }
    }
}