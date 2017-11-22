using PersonalFinance.Domain.Entities;
using PersonalFinance.Domain.Enuns;

namespace PersonalFinance.Test.Builder
{
    public class BankAccountBuilder
    {
        private int _id;
        private EnumBank _bank;
        private string _agencyNumber;
        private string _agencyDigit;
        private string _accountNumber;
        private string _accountDigit;
        private EnumBankAccountType _type;
        private double _amount;

        public BankAccountBuilder()
        {
            this._id = default(int);
            this._bank = EnumBank.BANCO_BRASIL;
            this._agencyNumber = string.Empty;
            this._agencyDigit = string.Empty;;
            this._accountNumber = string.Empty;
            this._accountDigit = string.Empty;
            this._type = EnumBankAccountType.CONTA_CORRENTE;
            this._amount = default(double);
        }

        public BankAccountBuilder WithId(int id)
        {
            this._id = id;
            return this;
        }

        public BankAccountBuilder WithBank(EnumBank bank)
        {
            this._bank = bank;
            return this;
        }

        public BankAccountBuilder WithAgencyNumber(string agencyNumber)
        {
            this._agencyNumber = agencyNumber;
            return this;
        }

        public BankAccountBuilder WithAgencyDigit(string agencyDigit)
        {
            this._agencyDigit = agencyDigit;
            return this;
        }

        public BankAccountBuilder WithAccountNumber(string accountNumber)
        {
            this._accountNumber = accountNumber;
            return this;
        }

        public BankAccountBuilder WithAccountDigit(string accountDigit)
        {
            this._accountDigit = accountDigit;
            return this;
        }

        public BankAccountBuilder WithType(EnumBankAccountType type)
        {
            this._type = type;
            return this;
        }

        public BankAccountBuilder WithAmount(double amount)
        {
            this._amount = amount;
            return this;
        }

        public BankAccount Builder()
        {
            var bankAccount = new BankAccount(this._bank, this._agencyNumber, this._agencyDigit,
                                              this._accountNumber, this._accountDigit,
                                              this._type, this._amount);
            bankAccount.Id = this._id;
            return bankAccount;
        } 
    }
}