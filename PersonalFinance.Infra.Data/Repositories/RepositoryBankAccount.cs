using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Repository;
using PersonalFinance.Infra.Data.Interfaces;

namespace PersonalFinance.Infra.Data.Repositories.Repository
{
    public class RepositoryBankAccount : RepositoryBase<BankAccount>, IRepositoryBankAccount
    {
        public RepositoryBankAccount(IContext context) 
            : base(context)
        {
        }

        public BankAccount GetByAccountNumberAndAgencyNumber(string accountNumber, string accountDigit, string agencyNumber, string agencyDigit)
        {
            throw new System.NotImplementedException();
        }
    }
}