using System.Collections.Generic;
using AutoMapper;
using PersonalFinance.Application.Interfaces;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.AutoMapper
{
    public class AutoMapperConverter : IConverter
    {
        private readonly IMapper _map;
        public AutoMapperConverter()
        {
            _map = AutoMapperConfig.IMap;
        }

        public TEntity ConvertDtoToTEntity<Dto, TEntity>(Dto dto)
            where Dto : class
            where TEntity : EntityBase
        {
            return _map.Map<Dto, TEntity>(dto);
        }

        public IEnumerable<TEntity> ConvertDtoToTEntity<Dto, TEntity>(IEnumerable<Dto> dto)
            where Dto : class
            where TEntity : EntityBase
        {
            return _map.Map<IEnumerable<Dto>, IEnumerable<TEntity>>(dto);
        }

        public Dto ConvertEntityToDto<TEntity, Dto>(TEntity entity)
            where TEntity : EntityBase
            where Dto : class
        {
            return _map.Map<TEntity, Dto>(entity);
        }

        public IEnumerable<Dto> ConvertEntityToDto<TEntity, Dto>(IEnumerable<TEntity> entity)
            where TEntity : EntityBase
            where Dto : class
        {
            return _map.Map<IEnumerable<TEntity>, IEnumerable<Dto>>(entity);
        }
    }
}