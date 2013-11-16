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
    public class OptionLoanManager : IBusinessLayer<OptionLoan>
    {
        #region [Private members]

        private readonly OptionLoanRepository _repository;

        #endregion


        #region [Ctor's]

        public OptionLoanManager()
        {
            _repository = new OptionLoanRepository();
        }

        public OptionLoanManager(BankContext context)
        {
            _repository = new OptionLoanRepository();
        }

        #endregion


        #region Implementation of IBusinessLayer<OptionLoan>

        public void AddEntity(OptionLoan value)
        {
            _repository.Add(value);
        }

        public void RemoveEntity(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateEntity(OptionLoan value)
        {
            _repository.Update(value);
        }

        public OptionLoan GetEntityById(int id)
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
