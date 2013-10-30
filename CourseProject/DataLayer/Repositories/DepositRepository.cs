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
    public class DepositRepository : Service<Deposit>, IDepositRepository
    {
        #region [Private members]

        private BankContext _context;

        #endregion

        #region [Ctor's]

        public DepositRepository(BankContext context)
        {
            _context = context;
        }

        public DepositRepository()
        {
            _context = new BankContext();
        }

        #endregion


        #region Overrides of Service<Deposit>

        public override void Add(Deposit value)
        {
            _context.Deposits.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.Deposits.Remove(value);
        }

        public override Deposit GetEntityById(int id)
        {
            return _context.Deposits.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion

        #region Implementation of IDepositRepository

        public List<Deposit> GetDepositsByCustomerId(int id)
        {
            return _context.Deposits.Where(e => e.CustomerId == id).ToList();
        }

        #endregion
    }
}
