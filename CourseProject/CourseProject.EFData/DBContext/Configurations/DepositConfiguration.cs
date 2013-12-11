using System.Data.Entity.ModelConfiguration;
using CourseProject.Core.Entities;

namespace CourseProject.EFData.DBContext.Configurations
{
    internal class DepositConfiguration : EntityTypeConfiguration<Deposit>
    {
        public DepositConfiguration()
        {
            Property(e => e.Summary).IsRequired();
            Property(e => e.OpeningSummary).IsRequired();
            Property(e => e.CreateDate).IsRequired();
            HasRequired(e => e.Customer).WithMany(e => e.Deposits).HasForeignKey(e => e.CustomerId);
            HasRequired(e => e.Currency).WithMany().HasForeignKey(e => e.CurrencyId);
            HasRequired(e => e.OptionDeposit).WithMany().HasForeignKey(e => e.OptionDepositId);
        }
    }
}
