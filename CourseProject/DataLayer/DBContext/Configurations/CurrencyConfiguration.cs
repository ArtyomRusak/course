using System;
using System.Data.Entity.ModelConfiguration;
using Core.Entities;

namespace DataLayer.DBContext.Configurations
{
    internal class CurrencyConfiguration : EntityTypeConfiguration<Currency>
    {
        public CurrencyConfiguration()
        {
            Property(e => e.Value).IsRequired();
        }
    }
}
