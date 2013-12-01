using System.Data.Entity;
using System.Linq;
using DataLayer.DBContext;
using Entities;

namespace DataLayer.Repositories
{
    public class HistoryRepository : Service<History>
    {
        #region [Private members]

        private readonly BankContext _context;
        private bool _disposed;

        #endregion


        #region [Ctor's]

        public HistoryRepository(BankContext context)
        {
            _context = context;
        }

        public HistoryRepository()
        {
            _context = new BankContext();
        }

        #endregion


        #region Overrides of Service<History>

        public override void Add(History value)
        {
            _context.Histories.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.Histories.Remove(value);
        }

        public override void Update(History value)
        {
            _context.Histories.Attach(value);
            _context.Entry(value).State = EntityState.Modified;
        }

        public override History GetEntityById(int id)
        {
            return _context.Histories.SingleOrDefault(e => e.Id == id);
        }

        public override IQueryable<History> All()
        {
            return _context.Histories;
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
