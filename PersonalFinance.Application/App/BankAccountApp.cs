using PersonalFinance.Application.DTOs;
using PersonalFinance.Application.Interfaces;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Services;
using PersonalFinance.Domain.Interfaces.UnitOfWork;

namespace PersonalFinance.Application.App
{
    public class BankAccountApp : AppBase<BankAccount, BankAccountDTO>, IBankAccountApp
    {
        private readonly IBankAccountService _service;
        public BankAccountApp(IBankAccountService service, IUnitOfWork unitOfWork, IConverter converter)
                : base(service, unitOfWork, converter) => _service = service;
    }
}