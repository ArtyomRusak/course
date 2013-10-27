using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DomainClasses;

namespace DataLayer.DBContext
{
    public class BankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}
