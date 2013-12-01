using System.Data.Entity;
using System.Linq;
using DataLayer.DBContext;
using Entities;

namespace DataLayer.Repositories
{
    public class AccountRepository : Service<Account>
    {
        #region [Private members]

        private readonly BankContext _context;
        private bool _disposed;

        #endregion


        #region [Ctor's]

        public AccountRepository(BankContext context)
        {
            _context = context;
        }

        public AccountRepository()
        {
            _context = new BankContext();
        }

        #endregion


        #region Overrides of Service<Account>

        public override void Add(Account value)
        {
            _context.Accounts.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.Accounts.Remove(value);
        }

        public override void Update(Account value)
        {
            _context.Accounts.Attach(value);
            _context.Entry(value).State = EntityState.Modified;
        }

        public override Account GetEntityById(int id)
        {
            return _context.Accounts.SingleOrDefault(e => e.Id == id);
        }

        public override IQueryable<Account> All()
        {
            return _context.Accounts;
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
