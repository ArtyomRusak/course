using System.Collections.Generic;
using DataLayer.DBContext;
using DataLayer.Repositories;
using Entities;

namespace BusinessLogicLayer.Managers
{
    public class CustomerManager : IBusinessLayer<Customer>
    {
        #region [Private members]

        private readonly CustomerRepository _repository;

        #endregion


        #region [Ctor's]

        public CustomerManager()
        {
            _repository = new CustomerRepository();
        }

        public CustomerManager(BankContext context)
        {
            _repository = new CustomerRepository(context);
        }

        #endregion


        #region Implementation of IBussinessLayer<Customer>

        public void AddEntity(Customer value)
        {
            _repository.Add(value);
        }

        public void RemoveEntity(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateEntity(Customer value)
        {
            _repository.Update(value);
        }

        public Customer GetEntityById(int id)
        {
            return _repository.GetEntityById(id);
        }

        public void Save()
        {
            _repository.Save();
        }

        #endregion


        #region [CutomerManager's members]

        public Customer GetCustomerByPassportData(string passportData)
        {
            return _repository.GetCustomerByPassportData(passportData);
        }

        public List<Customer> GetCustomersWhichContainsSurname(string surname)
        {
            return _repository.GetCustomersWhichContainsSurname(surname);
        }

        #endregion

    }
}
