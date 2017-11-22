using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.UnitOfWork;
using PersonalFinance.Infra.Data.Interfaces;

namespace PersonalFinance.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IContext _context;

        public UnitOfWork(IContext context)
        {
            _context = context;
        }
        public void Commit()
        {
           _context.Commit();   
        }
        public void StartTransaction()
        {
            _context.StartTransaction();
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}