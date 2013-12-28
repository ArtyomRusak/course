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

        public double Calculate(DateTime date)
        {
            var count = date - CreateDate;
            var days = (CreateDate.AddMonths(OptionDeposit.DurationInMonth) - CreateDate).TotalDays;
            var percents = OpeningSummary * OptionDeposit.Percent * days / (365 * 100);
            if (count.TotalDays > 365)
            {
                return percents;
            }
            else
            {
                var percent = percents / 12 * (int)(count.TotalDays / 30);
                return percent;
            }
        }
    }
}
