using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer.DBContext.Configurations
{
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            Property(e => e.Name).IsRequired().HasMaxLength(20);
            Property(e => e.Surname).IsRequired().HasMaxLength(40);
            Property(e => e.Patronymic).IsRequired().HasMaxLength(40);
            Property(e => e.BirthDate).HasColumnType("date").IsRequired();
            Property(e => e.Address).HasMaxLength(100);
            Property(e => e.Age).IsRequired();
            Property(e => e.PassportData).HasMaxLength(20).IsRequired();
        }
    }
}
