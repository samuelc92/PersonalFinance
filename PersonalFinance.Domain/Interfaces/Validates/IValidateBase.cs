using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Domain.Interfaces.Validates
{
    public interface IValidateBase<TEntity> where TEntity : EntityBase
    {
        bool AddValidate(TEntity entity);
        bool UpdateValidate(TEntity entity);
    }
}