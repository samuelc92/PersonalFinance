using PersonalFinance.Application.DTOs;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Interfaces
{
    public interface IBankAccountApp : IAppBase<BankAccount, BankAccountDTO>
    {
        
    }
}