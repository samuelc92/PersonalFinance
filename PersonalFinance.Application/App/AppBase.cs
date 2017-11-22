using System.Collections.Generic;
using AutoMapper;
using PersonalFinance.Application.AutoMapper;
using PersonalFinance.Application.Interfaces;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Services;
using PersonalFinance.Domain.Interfaces.UnitOfWork;

namespace PersonalFinance.Application.App
{
    public class AppBase<TEntity, DTO> : IAppBase<TEntity, DTO>
        where TEntity : EntityBase
        where DTO : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _map;
        private readonly IServiceBase<TEntity> _service;

        public AppBase(IServiceBase<TEntity> service, IUnitOfWork unitOfWork)
        {
            _service = service;
            _unitOfWork = unitOfWork;
            _map = AutoMapperConfig.IMap;
        }

        public DTO Add(DTO dto)
        {
            var entity = _map.Map<DTO, TEntity>(dto);

            _unitOfWork.StartTransaction();
            entity = _service.Add(entity);
            _unitOfWork.Commit();

            return _map.Map<TEntity, DTO>(entity);
        }

        public IEnumerable<DTO> GetAll() =>
            _map.Map<IEnumerable<TEntity>, IEnumerable<DTO>>(_service.GetAll());

        public DTO GetById(int id) =>
            _map.Map<TEntity, DTO>(_service.GetById(id));

        public void Remove(DTO dto)
        {
            var entity = _map.Map<DTO, TEntity>(dto);

            _unitOfWork.StartTransaction();
            _service.Remove(entity);
            _unitOfWork.Commit();
        }

        public void Update(DTO dto)
        {
            var entity = _map.Map<DTO, TEntity>(dto);

            _unitOfWork.StartTransaction();
            _service.Update(entity);
            _unitOfWork.Commit();
        }
    }
}