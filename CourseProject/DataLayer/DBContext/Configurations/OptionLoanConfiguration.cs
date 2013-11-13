using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

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
