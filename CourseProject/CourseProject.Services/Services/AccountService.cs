using System;
using System.Collections.Generic;
using System.Linq;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Core.Exceptions;
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;

namespace CourseProject.Services.Services
{
    public class AccountService : IService
    {
        #region [Private members]

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        #endregion


        #region [Ctor's]

        public AccountService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        #endregion


        #region [AccountService's members]

        public Account CreateAccount(double summary, int customerId, int currencyId)
        {
            Guard.AgainstNegatives((int) summary);

            var account = new Account
            {
                CreateDate = DateTime.Now,
                Summary = summary,
                CustomerId = customerId,
                CurrencyId = currencyId
            };

            var accountRepository = _factoryOfRepositories.GetAccountRepository();
            accountRepository.Create(account);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception exception)
            {
                throw new ServiceException(exception);
            }

            return account;
        }

        public void UpdateAccount(Account account)
        {
            var accountRepository = _factoryOfRepositories.GetAccountRepository();
            try
            {
                accountRepository.Update(account);
            }
            catch (Exception e)
            {
                throw new AccountServiceException(e);
            }
        }

        public void RemoveAccount(Account account)
        {
            var accountRepository = _factoryOfRepositories.GetAccountRepository();
            accountRepository.Remove(account);
        }

        public Account GetAccountById(int accountId)
        {
            var accountRepository = _factoryOfRepositories.GetAccountRepository();
            try
            {
                return accountRepository.GetEntityById(accountId);
            }
            catch (RepositoryException e)
            {
                throw new AccountServiceException(e.Message);
            }
        }

        public List<Account> GetAccountsByPassportData(string passportData)
        {
            var accountRepository = _factoryOfRepositories.GetAccountRepository();
            return accountRepository.Filter(e => e.Customer.PassportData == passportData).ToList();
        }

        public List<Account> GetAccountByCustomerSurname(string surname)
        {
            var accountRepository = _factoryOfRepositories.GetAccountRepository();
            return accountRepository.Filter(e => e.Customer.Surname.Contains(surname)).ToList();
        } 

        public List<Account> GetAccountsByCustomerId(int customerId)
        {
            var accountRepository = _factoryOfRepositories.GetAccountRepository();
            return accountRepository.Filter(e => e.CustomerId == customerId).ToList();
        }

        public int GetCountOfAllAccounts()
        {
            var accountRepository = _factoryOfRepositories.GetAccountRepository();
            return accountRepository.All().Count();
        }

        #endregion

    }
}
