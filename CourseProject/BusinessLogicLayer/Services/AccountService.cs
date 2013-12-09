using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Exceptions;
using Core;
using Core.Entities;
using Infrastructure.Guard.Validation;

namespace BusinessLogicLayer.Services
{
    public class AccountService : IService
    {
        #region [Private members]

        private IUnitOfWork _unitOfWork;
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
