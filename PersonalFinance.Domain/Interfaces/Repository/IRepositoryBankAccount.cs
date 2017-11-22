using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Domain.Interfaces.Repository
{
    public interface IRepositoryBankAccount : IRepositoryBase<BankAccount>
    {
        BankAccount GetByAccountNumberAndAgencyNumber(string accountNumber, string accountDigit, string agencyNumber, string agencyDigit);    
    }
}