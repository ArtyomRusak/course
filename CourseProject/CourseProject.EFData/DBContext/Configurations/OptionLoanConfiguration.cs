using System.Data.Entity.ModelConfiguration;
using CourseProject.Core.Entities;

namespace CourseProject.EFData.DBContext.Configurations
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
