using System;
using System.Data.Entity;
using DataLayer.DBContext;
using DataLayer.DBContext.Initializers;
using NUnit.Framework;
using Core.Entities;

namespace Tests
{
    [TestFixture]
    public partial class RepositoriesTests
    {
        [Test]
        public void ShouldAddCurrencyToDatabase()
        {
            BankContext context = new BankContext("TestDB");
            Database.SetInitializer(new RecreateAlways());
            context.Currencies.Add(new Currency() {Value = "USD"});
            context.SaveChanges();
            context.Dispose();
        }
    }
}
