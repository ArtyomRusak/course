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
    public class OptionLoanRepository : Service<OptionLoan>, IOptionLoanRepository
    {
        #region [Private members]

        private BankContext _context;

        #endregion


        #region [Ctor's]

        public OptionLoanRepository()
        {
            _context = new BankContext();
        }

        public OptionLoanRepository(BankContext context)
        {
            _context = context;
        }

        #endregion

        #region Overrides of Service<OptionLoan>

        public override void Add(OptionLoan value)
        {
            _context.OptionLoans.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.OptionLoans.Remove(value);
        }

        public override OptionLoan GetEntityById(int id)
        {
            return _context.OptionLoans.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion
    }
}
