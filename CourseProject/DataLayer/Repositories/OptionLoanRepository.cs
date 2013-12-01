using System.Data.Entity;
using System.Linq;
using DataLayer.DBContext;
using Entities;

namespace DataLayer.Repositories
{
    public class OptionLoanRepository : Service<OptionLoan>
    {
        #region [Private members]

        private readonly BankContext _context;
        private bool _disposed;

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

        public override void Update(OptionLoan value)
        {
            _context.OptionLoans.Attach(value);
            _context.Entry(value).State = EntityState.Modified;
        }

        public override OptionLoan GetEntityById(int id)
        {
            return _context.OptionLoans.SingleOrDefault(e => e.Id == id);
        }

        public override IQueryable<OptionLoan> All()
        {
            return _context.OptionLoans;
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
