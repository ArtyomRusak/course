using System.Data.Entity;
using System.Linq;
using DataLayer.DBContext;
using Entities;

namespace DataLayer.Repositories
{
    public class CurrencyRepository : Service<Currency>
    {
        #region [Private members]

        private readonly BankContext _context;
        private bool _disposed;

        #endregion


        #region [Ctor's]

        public CurrencyRepository()
        {
            _context = new BankContext();
        }

        public CurrencyRepository(BankContext context)
        {
            _context = context;
        }

        #endregion


        #region Overrides of Service<Currency>

        public override void Add(Currency value)
        {
            _context.Currencies.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.Currencies.Remove(value);
        }

        public override void Update(Currency value)
        {
            _context.Currencies.Attach(value);
            _context.Entry(value).State = EntityState.Modified;
        }

        public override Currency GetEntityById(int id)
        {
            return _context.Currencies.SingleOrDefault(e => e.Id == id);
        }

        public override IQueryable<Currency> All()
        {
            return _context.Currencies;
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
  