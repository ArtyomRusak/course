﻿using System;
using System.Data.Entity;
using System.Transactions;
using CourseProject.Core.Entities;

namespace CourseProject.EFData.DBContext.Initializers
{
    public class BankInitialization : IDatabaseInitializer<BankContext>
    {
        public void InitializeDatabase(BankContext context)
        {
            bool databaseExists;
            using (new TransactionScope(TransactionScopeOption.Suppress))
            {
                databaseExists = context.Database.Exists();
            }
            if (databaseExists)
            {
                if (context.Database.CompatibleWithModel(true))
                {
                    return;
                }
                context.Database.Delete();
            }
            context.Database.Create();
            context.Database.ExecuteSqlCommand("ALTER TABLE Customers ADD CONSTRAINT PassportDataUnique UNIQUE (PassportData)");
            context.Database.ExecuteSqlCommand("ALTER TABLE OptionDeposits ADD CONSTRAINT NameDataUnique UNIQUE (Name)");
            context.Database.ExecuteSqlCommand("ALTER TABLE Currencies ADD CONSTRAINT ValueDataUnique UNIQUE (Value)");
            try
            {
                Seed(context);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Dispose();
                throw;
            }
        }

        public void Seed(BankContext context)
        {
            var byr = new Currency { Value = "BYR" };
            var usd = new Currency { Value = "USD" };

            context.Currencies.Add(byr);
            context.Currencies.Add(usd);

            var sber = new OptionDeposit { Name = "Saving", Percent = 3, DurationInMonth = 12 };
            var orig = new OptionDeposit { Name = "Original", Percent = 5, DurationInMonth = 6 };
            var money = new OptionDeposit { Name = "Monetary", Percent = 9, DurationInMonth = 3 };

            context.OptionDeposits.Add(sber);
            context.OptionDeposits.Add(orig);
            context.OptionDeposits.Add(money);

            var beforeSalary = new OptionLoan { Name = "Before salary", Percent = 1, DurationInMonth = 12 };
            var loan = new OptionLoan { Name = "Loan at interest", Percent = 4, DurationInMonth = 6 };

            context.OptionLoans.Add(beforeSalary);
            context.OptionLoans.Add(loan);

            context.SaveChanges();
        }
    }
}
