using System;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Repository;

namespace PersonalFinance.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void StartTransaction();
    }
}