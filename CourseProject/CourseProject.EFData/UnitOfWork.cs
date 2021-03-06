﻿using System;
using System.Data.Entity;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Core.Exceptions;
using CourseProject.Core.InterfaceRepository;
using CourseProject.EFData.DBContext;
using CourseProject.EFData.Repositories;

namespace CourseProject.EFData
{
    public class UnitOfWork : IUnitOfWork, IRepositoryFactory
    {
        #region [Private members]

        private readonly BankContext _context;
        private readonly DbContextTransaction _transaction;
        private IRepository<Account> _accountRepository;
        private IRepository<Currency> _currencyRepository;
        private IRepository<Customer> _customerRepository;
        private IRepository<Deposit> _depositRepository;
        private IRepository<History> _historyRepository;
        private IRepository<Loan> _loanRepository;
        private IRepository<OptionDeposit> _optionDepositRepository;
        private IRepository<OptionLoan> _optionLoanRepository;
        private bool _disposed;
        private bool _isTransactionActive;

        #endregion


        #region [Ctor's]

        public UnitOfWork(BankContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();
            _isTransactionActive = true;
        }

        public UnitOfWork()
        {
            _context = new BankContext();
            _transaction = _context.Database.BeginTransaction();
        }

        #endregion


        #region Implementation of IRepositoryFactory

        public IRepository<Account> GetAccountRepository()
        {
            return _accountRepository ?? (_accountRepository = new Repository<Account>(_context));
        }

        public IRepository<Currency> GetCurrencyRepository()
        {
            return _currencyRepository ?? (_currencyRepository = new Repository<Currency>(_context));
        }

        public IRepository<Customer> GetCustomerRepository()
        {
            return _customerRepository ?? (_customerRepository = new Repository<Customer>(_context));
        }

        public IRepository<Deposit> GetDepositRepository()
        {
            return _depositRepository ?? (_depositRepository = new Repository<Deposit>(_context));
        }

        public IRepository<History> GetHistoryRepository()
        {
            return _historyRepository ?? (_historyRepository = new Repository<History>(_context));
        }

        public IRepository<Loan> GetLoanRepository()
        {
            return _loanRepository ?? (_loanRepository = new Repository<Loan>(_context));
        }

        public IRepository<OptionDeposit> GetOptionDepositRepository()
        {
            return _optionDepositRepository ?? (_optionDepositRepository = new Repository<OptionDeposit>(_context));
        }

        public IRepository<OptionLoan> GetOptionLoanRepository()
        {
            return _optionLoanRepository ?? (_optionLoanRepository = new Repository<OptionLoan>(_context));
        }

        #endregion


        #region Implementation of IDisposable

        public void Dispose()
        {
            if (_isTransactionActive)
            {
                try
                {
                    _context.SaveChanges();
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
                catch (Exception e)
                {
                    _transaction.Rollback();
                    _context.Dispose();
                    _disposed = true;
                    _isTransactionActive = false;
                    throw new RepositoryException(e);
                }
            }
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }

        #endregion


        #region Implementation of IUnitOfWork

        public void Commit()
        {
            try
            {
                if (_isTransactionActive && !_disposed)
                {
                    _context.SaveChanges();
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                _isTransactionActive = false;
                throw new RepositoryException(e.Message);
            }
        }

        public void Rollback()
        {
            if (_isTransactionActive && !_disposed)
            {
                _transaction.Rollback();
                _isTransactionActive = false;
            }
        }

        public void PreSave()
        {
            _context.SaveChanges();
        }

        #endregion
    }
}
