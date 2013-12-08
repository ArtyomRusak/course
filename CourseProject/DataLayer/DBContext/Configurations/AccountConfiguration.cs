using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace DataLayer.DBContext.Configurations
{
    internal class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            Property(e => e.CreateDate).HasColumnType("date").IsRequired();
            Property(e => e.Summary).IsRequired();
            HasRequired(e => e.Customer).WithMany(e => e.Accounts).HasForeignKey(e => e.CustomerId);
            HasRequired(e => e.Currency).WithMany().HasForeignKey(e => e.CurrencyId);
        }
    }
}
