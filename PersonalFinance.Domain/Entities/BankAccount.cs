using System;
using PersonalFinance.Domain.Enuns;

namespace PersonalFinance.Domain.Entities
{
    public class BankAccount : EntityBase
    {
        public EnumBank Bank { get; set; }
        public string AgencyNumber { get; set; }
        public string AgencyDigit { get; set; }
        public string AccountNumber { get; set; }
        public string AccountDigit { get; set; }
        public EnumBankAccountType Type { get; set; }
        public double Amount { get; set; }

        public BankAccount(EnumBank bank, string agencyNumber, string agencyDigit,
                         string accountNumer, string accountDigit, EnumBankAccountType type,
                         double amount )
        {
            this.Bank = bank;
            this.AccountDigit = accountDigit;
            this.AccountNumber = accountNumer;
            this.AgencyDigit = agencyDigit;
            this.AgencyNumber = agencyNumber;
            this.Type = type;
            this.Amount = amount;
        }

        public BankAccount(){}
        public override bool Validate()
        {
            if (string.IsNullOrEmpty(this.AgencyNumber))
                throw new Exception("Número da agência é obrigátorio.");
            if (string.IsNullOrEmpty(this.AgencyDigit))
                throw new Exception("Dígito da agência é obrigátorio.");
            if (string.IsNullOrEmpty(this.AccountNumber))
                throw new Exception("Número da conta é obrigátorio.");
            if (string.IsNullOrEmpty(this.AccountDigit))
                throw new Exception("Dígito da conta é obrigátorio.");
            
            return true;
        }
    }
}