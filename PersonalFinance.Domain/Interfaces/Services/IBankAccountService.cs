using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Domain.Interfaces.Services
{
    public interface IBankAccountService : IServiceBase<BankAccount>
    {
        BankAccount GetByAccountNumberAndAgencyNumber(string accountNumber, string accountDigit, string agencyNumber, string agencyDigit);
    }
}