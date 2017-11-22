using Dapper.FluentMap.Dommel.Mapping;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Infra.Data.EntityMap
{
    public class BankAccountMap : DommelEntityMap<BankAccount>
    {
        public BankAccountMap()
        {
            ToTable("BankAccount");

            Map(p => p.Id)
            .ToColumn("Id")
            .IsKey();

            Map(p => p.InsertDate)
            .ToColumn("InsertDate");

            Map(p => p.UpdateDate)
            .ToColumn("UpdateDate");

            Map(p => p.Bank)
            .ToColumn("Bank");

            Map(p => p.AgencyNumber)
            .ToColumn("AgencyNumber");

            Map(p => p.AgencyDigit)
            .ToColumn("AgencyDigit");

            Map(p => p.AccountNumber)
            .ToColumn("AccountNumber");

            Map(p => p.AccountDigit)
            .ToColumn("AccountDigit");

            Map(p => p.Type)
            .ToColumn("Type");

            Map(p => p.Amount)
            .ToColumn("Amount");
        }
    }
}