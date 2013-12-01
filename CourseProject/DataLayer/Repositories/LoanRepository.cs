using System.Data.Entity;
using System.Linq;
using DataLayer.DBContext;
using Entities;

namespace DataLayer.Repositories
{
    public class LoanRepository : Service<Loan>
    {
        #region [Private members]

        private readonly BankContext _context;
        private bool _disposed;

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
            return _context.Loans.SingleOrDefault(e => e.Id == id);
        }

        public override IQueryable<Loan> All()
        {
            return _context.Loans;
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        public override void Dispose()
        {
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }

        #endregion
    }
}
