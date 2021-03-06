﻿using System.Data.Entity.ModelConfiguration;
using CourseProject.Core.Entities;

namespace CourseProject.EFData.DBContext.Configurations
{
    internal class LoanConfiguration : EntityTypeConfiguration<Loan>
    {
        public LoanConfiguration()
        {
            Property(e => e.Summary).IsRequired();
            Property(e => e.OpeningSummary).IsRequired();
            Property(e => e.CreateDate).IsRequired();
            HasRequired(e => e.Customer).WithMany(e=>e.Loans).HasForeignKey(e => e.CustomerId);
            HasRequired(e => e.OptionLoan).WithMany().HasForeignKey(e => e.OptionLoanId);
            HasRequired(e => e.Currency).WithMany().HasForeignKey(e => e.CurrencyId);
        }
    }
}
