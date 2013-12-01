using System.Collections.Generic;
using System.Linq;
using DataLayer.DBContext;
using DataLayer.Repositories;
using Entities;

namespace BusinessLogicLayer.Managers
{
    public class HistoryManager : IBusinessLayer<History>
    {
        #region [Private members]

        private readonly HistoryRepository _repository;

        #endregion


        #region [Ctor's]

        public HistoryManager()
        {
            _repository = new HistoryRepository();
        }

        public HistoryManager(BankContext context)
        {
            _repository = new HistoryRepository(context);
        }

        #endregion


        #region Implementation of IBussinessLayer<History>

        public void AddEntity(History value)
        {
            _repository.Add(value);
        }

        public void RemoveEntity(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateEntity(History value)
        {
            _repository.Update(value);
        }

        public History GetEntityById(int id)
        {
            return _repository.GetEntityById(id);
        }

        public void Save()
        {
            _repository.Save();
        }

        #endregion


        #region [HistoryManager's members]

        public List<History> GetHistoriesByCustomerId(int id)
        {
            return _repository.All().Where(e => e.CustomerId == id).ToList();
        }

        #endregion

    }
}
