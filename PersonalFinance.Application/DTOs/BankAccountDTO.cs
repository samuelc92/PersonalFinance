namespace PersonalFinance.Application.DTOs
{
    public class BankAccountDTO
    {
        public short Bank { get; set; }
        public string AgencyNumber { get; set; }
        public string AgencyDigit { get; set; }
        public string AccountNumber { get; set; }
        public string AccountDigit { get; set; }
        public short Type { get; set; }
        public double Amount { get; set; }
    }
}