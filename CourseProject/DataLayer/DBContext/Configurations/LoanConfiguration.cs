using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DomainClasses;

namespace DataLayer.DBContext.Configurations
{
    internal class LoanConfiguration : EntityTypeConfiguration<Loan>
    {
        public LoanConfiguration()
        {
            Property(e => e.Summary).IsRequired();
            Property(e => e.OpeningSummary).IsRequired();
            HasRequired(e => e.Customer).WithMany(e=>e.Loans).HasForeignKey(e => e.CustomerId);
            HasRequired(e => e.OptionLoan).WithMany().HasForeignKey(e => e.OptionLoanId);
            HasRequired(e => e.Currency).WithMany().HasForeignKey(e => e.CurrencyId);
        }
    }
}
