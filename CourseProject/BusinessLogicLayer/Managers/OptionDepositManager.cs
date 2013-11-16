using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext;
using DataLayer.Repositories;
using Entities;

namespace BusinessLogicLayer.Managers
{
    public class OptionDepositManager : IBusinessLayer<OptionDeposit>
    {
        #region [Private members]

        private readonly OptionDepositRepository _repository;

        #endregion


        #region [Ctor's]

        public OptionDepositManager()
        {
            _repository = new OptionDepositRepository();
        }

        public OptionDepositManager(BankContext context)
        {
            _repository = new OptionDepositRepository(context);
        }

        #endregion


        #region Implementation of IBusinessLayer<OptionDeposit>

        public void AddEntity(OptionDeposit value)
        {
            _repository.Add(value);
        }

        public void RemoveEntity(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateEntity(OptionDeposit value)
        {
            _repository.Update(value);
        }

        public OptionDeposit GetEntityById(int id)
        {
            return _repository.GetEntityById(id);
        }

        public void Save()
        {
            _repository.Save();
        }

        #endregion
    }
}
