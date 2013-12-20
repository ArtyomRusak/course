using System.Data.Entity.ModelConfiguration;
using CourseProject.Core.Entities;

namespace CourseProject.EFData.DBContext.Configurations
{
    internal class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            Property(e => e.CreateDate).HasColumnType("date").IsRequired();
            Property(e => e.Summary).IsRequired();
            HasRequired(e => e.Customer).WithMany(e => e.Accounts).HasForeignKey(e => e.CustomerId);
            HasRequired(e => e.Currency).WithMany().HasForeignKey(e => e.CurrencyId);
            //HasRequired(e => e.Currency).WithOptional().Map(x => x.MapKey("CurrencyId"));
        }
    }
}
