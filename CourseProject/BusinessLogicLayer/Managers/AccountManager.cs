using System.Collections.Generic;
using DataLayer.DBContext;
using DataLayer.Repositories;
using Entities;

namespace BusinessLogicLayer.Managers
{
    public class AccountManager : IBusinessLayer<Account>
    {
        #region [Private members]

        private readonly AccountRepository _repository;

        #endregion


        #region [Ctor's]

        public AccountManager()
        {
            _repository = new AccountRepository();
        }

        public AccountManager(BankContext context)
        {
            _repository = new AccountRepository(context);
        }

        #endregion


        #region Implementation of IBussinessLayer<Account>

        public void AddEntity(Account value)
        {
            _repository.Add(value);
        }

        public void RemoveEntity(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateEntity(Account value)
        {
            _repository.Update(value);
        }

        public Account GetEntityById(int id)
        {
            return _repository.GetEntityById(id);
        }

        public void Save()
        {
            _repository.Save();
        }

        #endregion

        #region [AccountManager's members]

        public List<Account> GetAccountsByCustomerId(int id)
        {
            return _repository.GetAccountsByCustomerId(id);
        }

        #endregion

    }
}
