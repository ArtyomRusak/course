﻿using System;
using System.Data.Entity;
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
            Database.SetInitializer(new RecreateIfModelChanges());
            context.Currencies.Add(new Currency() { Value = "USD" });
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
            //context.Customers.Add(customer);
            var unitOfWork = new UnitOfWork(context);
            //IRepositoryFactory repositoryFactory = (IRepositoryFactory) unitOfWork;
            MembershipService service = new MembershipService(unitOfWork, unitOfWork);
            var customer1 = service.CreateCustomer("a", "b", "c", "mp1", "d", new DateTime(1994, 4, 20));

            context.Customers.Add(new Customer()
            {
                Name = "a",
                Surname = "s",
                Patronymic = "sd",
                Address = "1",
                Age = 13,
                BirthDate = DateTime.Now,
                PassportData = "123"
            });
            context.SaveChanges();
            context.Dispose();
        }
    }
}
