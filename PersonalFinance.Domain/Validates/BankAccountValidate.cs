using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Repository;
using PersonalFinance.Domain.Interfaces.Validates;

namespace PersonalFinance.Domain.Validates
{
    public class BankAccountValidate : ValidateBase<BankAccount>, IBankAccountValidate
    {
        private readonly IRepositoryBankAccount _repository;
        public BankAccountValidate(IRepositoryBankAccount repository)
            : base(repository) => _repository = repository;
    }
}