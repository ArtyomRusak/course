using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace DataLayer.DBContext.Configurations
{
    internal class OptionLoanConfiguration : EntityTypeConfiguration<OptionLoan>
    {
        public OptionLoanConfiguration()
        {
            Property(e => e.Name).HasMaxLength(20).IsRequired();
            Property(e => e.Percent).IsRequired();
        }
    }
}
