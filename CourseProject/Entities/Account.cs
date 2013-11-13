using System;

namespace Entities
{
    public class Account
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public double Summary { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
    }
}
