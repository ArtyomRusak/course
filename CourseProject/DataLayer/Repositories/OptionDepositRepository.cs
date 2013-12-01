using System.Data.Entity;
using System.Linq;
using DataLayer.DBContext;
using Entities;

namespace DataLayer.Repositories
{
    public class OptionDepositRepository : Service<OptionDeposit>
    {
        #region [Private members]

        private readonly BankContext _context;
        private bool _disposed;

        #endregion


        #region [Ctor's]

        public OptionDepositRepository(BankContext context)
        {
            _context = context;
        }

        public OptionDepositRepository()
        {
            _context = new BankContext();
        }

        #endregion


        #region Overrides of Service<OptionDeposit>

        public override void Add(OptionDeposit value)
        {
            _context.OptionDeposits.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.OptionDeposits.Remove(value);
        }

        public override void Update(OptionDeposit value)
        {
            _context.OptionDeposits.Attach(value);
            _context.Entry(value).State = EntityState.Modified;
        }

        public override OptionDeposit GetEntityById(int id)
        {
            return _context.OptionDeposits.SingleOrDefault(e => e.Id == id);
        }

        public override IQueryable<OptionDeposit> All()
        {
            return _context.OptionDeposits;
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
