using System;
using System.Collections.Generic;
using System.Linq;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;

namespace CourseProject.Services.Services
{
    public class MembershipService : IService
    {
        #region [Private members]

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        #endregion


        #region [Ctor's]

        public MembershipService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        #endregion


        #region [MembershipService's members]

        public Customer CreateCustomer(string name, string surname, string patronymic, string passportData,
            string address, DateTime birthDate)
        {
            var customer = new Customer()
            {
                Name = name,
                Surname = surname,
                Patronymic = patronymic,
                PassportData = passportData.ToUpper(),
                Address = address,
                BirthDate = birthDate
            };
            customer.SetAge();

            var customerRepository = _factoryOfRepositories.GetCustomerRepository();
            customerRepository.Create(customer);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception e)
            {
                throw new ServiceException(e);
            }

            return customer;
        }

        public Customer GetCustomerByPassportData(string passportData)
        {
            var customerRepository = _factoryOfRepositories.GetCustomerRepository();
            var customer = customerRepository.Find(e => e.PassportData == passportData);
            if (customer == null)
            {
                throw new MembershipServiceException("Customer doesn't exist.");
            }
            return customer;
        }

        public List<Customer> GetCustomersBySurname(string surname)
        {
            var customerRepository = _factoryOfRepositories.GetCustomerRepository();
            try
            {
                return customerRepository.Filter(e => e.Surname.Contains(surname)).ToList();
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e.Message);
            }
        } 

        public Customer GetCustomerById(int userId)
        {
            var customerRepository = _factoryOfRepositories.GetCustomerRepository();
            var customer = customerRepository.GetEntityById(userId);
            if (customer == null)
            {
                throw new MembershipServiceException("Customer doesn't exist.");
            }
            return customer;
        }

        public void UpdateCustomer(Customer customer)
        {
            var customerRepository = _factoryOfRepositories.GetCustomerRepository();
            try
            {
                customerRepository.Update(customer);
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e);
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            var customerRepository = _factoryOfRepositories.GetCustomerRepository();
            customerRepository.Remove(customer);
        }

        public int GetCountOfAllCustomers()
        {
            var customerRepository = _factoryOfRepositories.GetCustomerRepository();
            return customerRepository.All().Count();
        }

        #endregion

    }
}
