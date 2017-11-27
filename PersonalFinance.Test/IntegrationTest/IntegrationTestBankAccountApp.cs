using PersonalFinance.Application.DTOs;
using PersonalFinance.Application.Interfaces;
using PersonalFinance.Infra.CrossCutting.IoC;
using NUnit.Framework;
using PersonalFinance.Application.AutoMapper;

namespace PersonalFinance.Test
{
    [TestFixture]
    public class IntegrationTestBankAccountApp
    {
        [Test]
        public void ShouldAdd()
        {
            AutoMapperConfig.RegisterMappings();
            IBankAccountApp bankAccountApp = new BootStrapper().Container.GetInstance<IBankAccountApp>();
            var bankAccountBD = bankAccountApp.Add(dto: new BankAccountDTO
            {
                AccountNumber = "38852",
                AccountDigit = "1",
                AgencyDigit = "4",
                AgencyNumber = "35552",
                Bank = 1,
                Amount = 125,
                Type = 1
            });

        }
    }
}