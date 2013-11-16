using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext;
using DataLayer.Repositories.Contracts;
using Entities;

namespace DataLayer.Repositories
{
    public class LoanRepository : Service<Loan>, ILoanRepository
    {
        #region [Private members]

        private readonly BankContext _context;

        #endregion


        #region [Ctor's]

        public LoanRepository()
        {
            _context = new BankContext();
        }

        public LoanRepository(BankContext context)
        {
            _context = context;
        }

        #endregion


        #region Overrides of Service<Loan>

        public override void Add(Loan value)
        {
            _context.Loans.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.Loans.Remove(value);
        }

        public override void Update(Loan value)
        {
            _context.Loans.Attach(value);
            _context.Entry(value).State = EntityState.Modified;
        }

        public override Loan GetEntityById(int id)
        {
            return _context.Loans.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion


        #region Implementation of ILoanRepository

        public List<Loan> GetLoansByCustomerId(int id)
        {
            return _context.Loans.Where(e => e.CustomerId == id).ToList();
        }

        #endregion
    }
}
