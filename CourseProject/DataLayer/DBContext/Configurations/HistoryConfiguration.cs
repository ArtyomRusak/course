using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace DataLayer.DBContext.Configurations
{
    internal class HistoryConfiguration : EntityTypeConfiguration<History>
    {
        public HistoryConfiguration()
        {
            HasRequired(e => e.Customer).WithMany(e => e.Histories).HasForeignKey(e => e.CustomerId);
            Property(e => e.Content).IsRequired();
        }
    }
}
