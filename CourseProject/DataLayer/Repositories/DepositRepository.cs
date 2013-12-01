using System.Data.Entity;
using System.Linq;
using DataLayer.DBContext;
using Entities;

namespace DataLayer.Repositories
{
    public class DepositRepository : Service<Deposit>
    {
        #region [Private members]

        private readonly BankContext _context;
        private bool _disposed;

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

        public override void Update(Deposit value)
        {
            _context.Deposits.Attach(value);
            _context.Entry(value).State = EntityState.Modified;
        }

        public override Deposit GetEntityById(int id)
        {
            return _context.Deposits.SingleOrDefault(e => e.Id == id);
        }

        public override IQueryable<Deposit> All()
        {
            return _context.Deposits;
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
