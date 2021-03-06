﻿using System.Data.Entity.ModelConfiguration;
using CourseProject.Core.Entities;

namespace CourseProject.EFData.DBContext.Configurations
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
            HasMany(e => e.Deposits).WithRequired(e => e.Customer).HasForeignKey(e => e.CustomerId);
        }
    }
}
