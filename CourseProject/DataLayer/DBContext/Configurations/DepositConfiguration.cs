using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer.DBContext.Configurations
{
    internal class DepositConfiguration : EntityTypeConfiguration<Deposit>
    {
        public DepositConfiguration()
        {
            Property(e => e.Summary).IsRequired();
            Property(e => e.OpeningSummary).IsRequired();
            HasRequired(e => e.Customer).WithMany(e => e.Deposits).HasForeignKey(e => e.CustomerId);
            HasRequired(e => e.Currency).WithMany().HasForeignKey(e => e.CurrencyId);
            HasRequired(e => e.OptionDeposit).WithMany().HasForeignKey(e => e.OptionDepositId);
        }
    }
}
