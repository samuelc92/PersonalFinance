using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Repository;
using PersonalFinance.Domain.Interfaces.Services;
using PersonalFinance.Domain.Interfaces.Validates;

namespace PersonalFinance.Domain.Services
{
    public class BankAccountService : ServiceBase<BankAccount>, IBankAccountService
    {
        private readonly IRepositoryBankAccount _repository;
        private readonly IBankAccountValidate _validate;

        public BankAccountService(IRepositoryBankAccount repository, IBankAccountValidate validate) 
            : base(repository, validate)
        {
            _repository = repository;
            _validate = validate;
        }

        public BankAccount GetByAccountNumberAndAgencyNumber(string accountNumber, string accountDigit, string agencyNumber, string agencyDigit) =>
         _repository.GetByAccountNumberAndAgencyNumber(accountNumber, accountDigit, agencyNumber, agencyDigit);
    }
}