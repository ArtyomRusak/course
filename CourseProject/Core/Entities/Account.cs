using System;

namespace Core.Entities
{
    public class Account : Entity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public double Summary { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
    }
}
