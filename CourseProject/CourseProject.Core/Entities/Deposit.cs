using System;
using CourseProject.Infrastructure.Guard.Validation;

namespace CourseProject.Core.Entities
{
    public class Deposit : Entity
    {
        public int Id { get; set; }
        public double Summary { get; set; }
        public double OpeningSummary { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public virtual OptionDeposit OptionDeposit { get; set; }
        public int OptionDepositId { get; set; }
    }
}
