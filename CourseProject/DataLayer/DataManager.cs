using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext;
using DataLayer.DomainClasses;

namespace DataLayer
{
    public class DataManager
    {
        #region [Private fields]

        private BankContext _context;

        #endregion


        #region [Ctor's]

        public DataManager()
        {
            _context = new BankContext();
        }

        #endregion


        #region [Customer's members]

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        #endregion


        #region [Account's members]

        public List<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }

        #endregion


        #region [Deposit's members]

        public List<Deposit> GetAllDeposits()
        {
            return _context.Deposits.ToList();
        }

        #endregion


        #region [History's members]

        public List<History> GetAllHistories()
        {
            return _context.Histories.ToList();
        }

        #endregion


        #region [Currency's members]

        public List<Currency> GetAllCurrencies()
        {
            return _context.Currencies.ToList();
        }

        #endregion


        #region [OptionDeposit's members]

        public List<OptionDeposit> GetAllOptionDeposits()
        {
            return _context.OptionDeposits.ToList();
        }

        public void AddOptionDeposit(OptionDeposit option)
        {
            _context.OptionDeposits.Add(option);
            _context.SaveChanges();
        }

        public void RemoveOptionDepositById(int id)
        {
            var option = GetOptionDepositById(id);
            _context.OptionDeposits.Remove(option);
            _context.SaveChanges();
        }

        public OptionDeposit GetOptionDepositById(int id)
        {
            return _context.OptionDeposits.FirstOrDefault(e => e.Id == id);
        }

        #endregion

    }
}
