using System.Data.Entity.ModelConfiguration;
using CourseProject.Core.Entities;

namespace CourseProject.EFData.DBContext.Configurations
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