using System.Collections.Generic;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Interfaces
{
    public interface IConverter
    {
        Dto ConvertEntityToDto<TEntity, Dto>(TEntity entity) 
        where TEntity : EntityBase
        where Dto : class;

        IEnumerable<Dto> ConvertEntityToDto<TEntity, Dto>(IEnumerable<TEntity> entity) 
        where TEntity : EntityBase
        where Dto : class;

        TEntity ConvertDtoToTEntity<Dto, TEntity>(Dto dto)
        where TEntity : EntityBase
        where Dto : class;

        IEnumerable<TEntity> ConvertDtoToTEntity<Dto, TEntity>(IEnumerable<Dto> dto)
        where TEntity : EntityBase
        where Dto : class;
    }
}