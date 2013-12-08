using System;
using System.Data.Entity;
using Core.Entities;
using DataLayer.DBContext.Configurations;

namespace DataLayer.DBContext
{
    public class BankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<OptionDeposit> OptionDeposits { get; set; }
        public DbSet<OptionLoan> OptionLoans { get; set; }

        public BankContext()
        {
            
        }

        public BankContext(string connectionString) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new CurrencyConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new DepositConfiguration());
            modelBuilder.Configurations.Add(new HistoryConfiguration());
            modelBuilder.Configurations.Add(new OptionDepositConfiguration());
            modelBuilder.Configurations.Add(new OptionLoanConfiguration());
            modelBuilder.Configurations.Add(new LoanConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
