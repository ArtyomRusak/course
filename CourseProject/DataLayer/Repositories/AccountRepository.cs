﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.DBContext;
using DataLayer.DomainClasses;
using DataLayer.Repositories.Contracts;

namespace DataLayer.Repositories
{
    public class AccountRepository : Service<Account>, IAccountRepository
    {
        #region [Private members]

        private readonly BankContext _context;

        #endregion


        #region [Ctor's]

        public AccountRepository(BankContext context)
        {
            _context = context;
        }

        public AccountRepository()
        {
            _context = new BankContext();
        }

        #endregion

        #region Overrides of Service<Account>

        public override void Add(Account value)
        {
            _context.Accounts.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.Accounts.Remove(value);
        }

        public override Account GetEntityById(int id)
        {
            return _context.Accounts.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion

        #region Implementation of IAccountRepository

        public List<Account> GetAccountsByCustomerId(int id)
        {
            return _context.Accounts.Where(e => e.CustomerId == id).ToList();
        }

        #endregion
    }
}
