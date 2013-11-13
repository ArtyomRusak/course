using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

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
