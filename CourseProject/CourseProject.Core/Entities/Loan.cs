﻿using System;

namespace CourseProject.Core.Entities
{
    public class Loan : Entity
    {
        public int Id { get; set; }
        public double Summary { get; set; }
        public double OpeningSummary { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public virtual OptionLoan OptionLoan { get; set; }
        public int OptionLoanId { get; set; }

        public double Calculate(DateTime date)
        {
            var count = date - CreateDate;
            var percents = (OpeningSummary*OptionLoan.Percent*
                            (CreateDate.AddMonths(OptionLoan.DurationInMonth) - CreateDate).TotalDays)/(365*100);
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
