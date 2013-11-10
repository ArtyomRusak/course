using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext;
using DataLayer.DomainClasses;
using DataLayer.Repositories.Contracts;

namespace DataLayer.Repositories
{
    public class CustomerRepository : Service<Customer>, ICustomerRepository
    {
        #region [Private members]

        private BankContext _context;

        #endregion

        #region [Ctor's]

        public CustomerRepository()
        {
            _context = new BankContext();
        }

        public CustomerRepository(BankContext context)
        {
            _context = context;
        }

        #endregion

        #region Overrides of Service<Customer>

        public override void Add(Customer value)
        {
            _context.Customers.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.Customers.Remove(value);
        }

        public override Customer GetEntityById(int id)
        {
            return _context.Customers.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion

        #region Implementation of ICustomerRepository

        public Customer GetCustomerByPassportData(string passportData)
        {
            return _context.Customers.FirstOrDefault(e => e.PassportData == passportData);
        }

        public List<Customer> GetCustomersWhichContainsSurname(string surname)
        {
            return _context.Customers.Where(e => e.Surname.Contains(surname)).ToList();
        }

        #endregion
    }
}
