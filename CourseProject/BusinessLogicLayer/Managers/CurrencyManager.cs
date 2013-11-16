using DataLayer.DBContext;
using DataLayer.Repositories;
using Entities;

namespace BusinessLogicLayer.Managers
{
    public class CurrencyManager : IBusinessLayer<Currency>
    {
        #region [Private members]

        private readonly CurrencyRepository _repository;

        #endregion


        #region [Ctor's]

        public CurrencyManager()
        {
            _repository = new CurrencyRepository();
        }

        public CurrencyManager(BankContext context)
        {
            _repository = new CurrencyRepository(context);
        }

        #endregion


        #region Implementation of IBussinessLayer<Currency>

        public void AddEntity(Currency value)
        {
            _repository.Add(value);
        }

        public void RemoveEntity(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateEntity(Currency value)
        {
            _repository.Update(value);
        }

        public Currency GetEntityById(int id)
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
