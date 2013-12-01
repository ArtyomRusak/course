using System.Collections.Generic;
using System.Linq;
using DataLayer.DBContext;
using DataLayer.Repositories;
using Entities;

namespace BusinessLogicLayer.Managers
{
    public class LoanManager : IBusinessLayer<Loan>
    {
        #region [Private members]

        private readonly LoanRepository _repository;

        #endregion


        #region [Ctor's]

        public LoanManager()
        {
            _repository = new LoanRepository();
        }

        public LoanManager(BankContext context)
        {
            _repository = new LoanRepository(context);
        }

        #endregion


        #region [Implementation of IBusinessLayer<Loan>]

        public void AddEntity(Loan value)
        {
            _repository.Add(value);
        }

        public void RemoveEntity(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateEntity(Loan value)
        {
            _repository.Update(value);
        }

        public Loan GetEntityById(int id)
        {
            return _repository.GetEntityById(id);
        }

        public void Save()
        {
            _repository.Save();
        }

        #endregion


        #region [LoanManager's members]

        public List<Loan> GetLoansByCustomerId(int id)
        {
            return _repository.All().Where(e => e.CustomerId == id).ToList();
        }

        #endregion

    }
}
