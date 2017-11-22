using System;
using PersonalFinance.Application.App;
using PersonalFinance.Application.Interfaces;
using PersonalFinance.Domain.Interfaces.Repository;
using PersonalFinance.Domain.Interfaces.Services;
using PersonalFinance.Domain.Interfaces.UnitOfWork;
using PersonalFinance.Domain.Interfaces.Validates;
using PersonalFinance.Domain.Services;
using PersonalFinance.Domain.Validates;
using PersonalFinance.Infra.Data.Context;
using PersonalFinance.Infra.Data.Interfaces;
using PersonalFinance.Infra.Data.Repositories;
using PersonalFinance.Infra.Data.Repositories.Repository;
using PersonalFinance.Infra.Data.UnitOfWork;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace PersonalFinance.Infra.CrossCutting.IoC
{
    public class BootStrapper : IDisposable
    {
        private Container _container;
        public Container Container
        {
            get
            {
                if (_container == null)
                    RegisterServices();
                return _container;
            }
        }

        public void RegisterServices()
        {
            _container = new Container();
            _container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);
            _container.Register<IContext, DapperContext>(Lifestyle.Singleton);
            
            _container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Singleton);
            _container.Register<IRepositoryBankAccount, RepositoryBankAccount>(Lifestyle.Singleton);
            _container.Register(typeof(IValidateBase<>), typeof(ValidateBase<>), Lifestyle.Singleton);
            _container.Register<IBankAccountValidate, BankAccountValidate>(Lifestyle.Singleton);
            _container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Singleton);
            _container.Register<IBankAccountService, BankAccountService>(Lifestyle.Singleton);
            _container.Register(typeof(IAppBase<,>), typeof(AppBase<,>), Lifestyle.Singleton);
            _container.Register<IBankAccountApp, BankAccountApp>(Lifestyle.Singleton);
            _container.Verify();
        }

        public void Dispose()
        {
            if (_container != null)
                _container.Dispose();
        }
    }
}