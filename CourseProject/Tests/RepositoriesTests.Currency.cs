using System;
using System.Data.Entity;
using System.Linq;
using CourseProject.Core.Entities;
using CourseProject.EFData;
using CourseProject.EFData.DBContext;
using CourseProject.EFData.DBContext.Initializers;
using CourseProject.Services.Services;
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
            var beginTransaction = context.Database.BeginTransaction();
            Database.SetInitializer(new DropCreateDatabaseAlways<BankContext>());
            //context.Currencies.Add(new Currency() { Value = "USD" });
            var customer = new Customer()
            {
                Name = "a",
                Surname = "s",
                Patronymic = "23",
                Address = "1",
                Age = 13,
                BirthDate = DateTime.Now,
                PassportData = "12"
            };
            context.Customers.Add(customer);
            context.SaveChanges();
            //var unitOfWork = new UnitOfWork(context);
            ////IRepositoryFactory repositoryFactory = (IRepositoryFactory) unitOfWork;
            //MembershipService service = new MembershipService(unitOfWork, unitOfWork);
            //var customer1 = service.CreateCustomer("a", "b", "c", "mp1", "d", new DateTime(1994, 4, 20));
            //context.Customers.Add(new Customer()
            //{
            //    Name = "a",
            //    Surname = "s",
            //    Patronymic = "sd",
            //    Address = "1",
            //    Age = 13,
            //    BirthDate = DateTime.Now,
            //    PassportData = "123"
            //});
            //context.SaveChanges();
            //unitOfWork.Commit();

            BankContext context1 = new BankContext("TestDB");
            var transaction = context1.Database.BeginTransaction();
            Customer find = context1.Customers.Find(customer.Id);
            context1.Currencies.Add(new Currency() {Value = "usd"});
            context1.SaveChanges();
            transaction.Commit();
            context1.Dispose();


            var currency = context.Currencies.SingleOrDefault(e => e.Value=="usd");

            beginTransaction.Commit();
            context.Dispose();
        }
    }
}
