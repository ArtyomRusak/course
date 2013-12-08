using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace DataLayer.DBContext.Configurations
{
    internal class OptionDepositConfiguration : EntityTypeConfiguration<OptionDeposit>
    {
        public OptionDepositConfiguration()
        {
            Property(e => e.Name).HasMaxLength(20).IsRequired();
            Property(e => e.Percent).IsRequired();
        }
    }
}