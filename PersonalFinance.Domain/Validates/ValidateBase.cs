using System;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Repository;
using PersonalFinance.Domain.Interfaces.Validates;

namespace PersonalFinance.Domain.Validates
{
    public class ValidateBase<TEntity> : IValidateBase<TEntity>
        where TEntity : EntityBase
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ValidateBase(IRepositoryBase<TEntity> repository) => 
            _repository = repository;

        public bool AddValidate(TEntity entity) => Validate(entity);

        public bool UpdateValidate(TEntity entity)
        {
            if (!Validate(entity))
                return false;
            
            if (_repository.GetById(entity.Id) == null)
                throw new Exception("Entity doesn't exist in database");

            return true;
        }

        private bool Validate(TEntity entity)
        {
            if (entity == null)
             throw new Exception("Entity couldn't be null");

            if (!entity.Validate())
                return false;
            
            return true;
        }
    }
}