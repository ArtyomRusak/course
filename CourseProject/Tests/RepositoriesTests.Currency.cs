using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext;
using DataLayer.DBContext.Initializers;
using Entities;
using NUnit.Framework;

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
