using System.Collections.Generic;
using DataLayer.DBContext;
using DataLayer.Repositories;
using Entities;

namespace BusinessLogicLayer.Managers
{
    public class DepositManager : IBusinessLayer<Deposit>
    {
        #region [Private members]

        private readonly DepositRepository _repository;

        #endregion


        #region [Ctor's]

        public DepositManager()
        {
            _repository = new DepositRepository();
        }

        public DepositManager(BankContext context)
        {
            _repository = new DepositRepository(context);
        }

        #endregion

        #region Implementation of IBussinessLayer<Deposit>

        public void AddEntity(Deposit value)
        {
            _repository.Add(value);
        }

        public void RemoveEntity(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateEntity(Deposit value)
        {
            _repository.Update(value);
        }

        public Deposit GetEntityById(int id)
        {
            return _repository.GetEntityById(id);
        }

        public void Save()
        {
            _repository.Save();
        }

        #endregion

        #region [DepositManager's members]

        public List<Deposit> GetDepositsByCustomerId(int id)
        {
            return _repository.GetDepositsByCustomerId(id);
        }

        #endregion

    }
}
