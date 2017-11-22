using System.Collections.Generic;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Interfaces
{
    public interface IAppBase<TEntity, DTO>
     where TEntity : EntityBase
     where DTO : class
    {
        DTO Add(DTO dto);
        DTO GetById(int id);
        IEnumerable<DTO> GetAll();
        void Update(DTO dto);
        void Remove(DTO dto);
    }
}