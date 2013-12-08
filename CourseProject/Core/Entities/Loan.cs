namespace Core.Entities
{
    public class Loan : Entity
    {
        public int Id { get; set; }
        public double Summary { get; set; }
        public double OpeningSummary { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public OptionLoan OptionLoan { get; set; }
        public int OptionLoanId { get; set; }
    }
}
