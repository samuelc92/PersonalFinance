using System;
using Moq;
using NUnit.Framework;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Interfaces.Repository;
using PersonalFinance.Domain.Services;
using PersonalFinance.Domain.Validates;
using PersonalFinance.Test.Builder;

namespace PersonalFinance.Test.UnitTest
{
    [TestFixture]
    public class BankAccountServiceTest
    {
        [Test]
        public void Should_Add()
        {
            var mockDependency = new Mock<IRepositoryBankAccount>();
            mockDependency.Setup(x => x.Add(It.IsAny<BankAccount>()))
                          .Returns(1);

            var bankAccountService = new BankAccountService(mockDependency.Object,
                                            new BankAccountValidate(mockDependency.Object));
            var bankAccount = bankAccountService.Add(
               new BankAccountBuilder().WithAgencyNumber("35552")
                                       .WithAgencyDigit("4")
                                       .WithAccountNumber("38852")
                                       .WithAccountDigit("1")
                                       .Builder());
            Assert.AreEqual(bankAccount.Id, 1);
        }

        [Test]
        public void Dont_Should_Add_With_AgencyNumber_Empty()
        {
            var mockDependency = new Mock<IRepositoryBankAccount>();
            mockDependency.Setup(x => x.Add(It.IsAny<BankAccount>()))
                          .Returns(1);

            var bankAccountService = new BankAccountService(mockDependency.Object,
                                            new BankAccountValidate(mockDependency.Object));
            try
            {
                var bankAccount = bankAccountService.Add(
                    new BankAccountBuilder().WithAgencyDigit("4")
                                       .WithAccountNumber("38852")
                                       .WithAccountDigit("1")
                                       .Builder());
                Assert.Fail();
            }catch(Exception ex)
            {
                Assert.AreEqual(ex.Message, "Número da agência é obrigátorio.");
            } 
        }
    }
}