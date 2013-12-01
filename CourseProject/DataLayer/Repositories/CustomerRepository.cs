using System.Data.Entity;
using System.Linq;
using DataLayer.DBContext;
using Entities;

namespace DataLayer.Repositories
{
    public class CustomerRepository : Service<Customer>
    {
        #region [Private members]

        private readonly BankContext _context;
        private bool _disposed;

        #endregion


        #region [Ctor's]

        public CustomerRepository()
        {
            _context = new BankContext();
        }

        public CustomerRepository(BankContext context)
        {
            _context = context;
        }

        #endregion


        #region Overrides of Service<Customer>

        public override void Add(Customer value)
        {
            _context.Customers.Add(value);
        }

        public override void Remove(int id)
        {
            var value = GetEntityById(id);
            _context.Customers.Remove(value);
        }

        public override void Update(Customer value)
        {
            _context.Customers.Attach(value);
            _context.Entry(value).State = EntityState.Modified;
        }

        public override Customer GetEntityById(int id)
        {
            return _context.Customers.SingleOrDefault(e => e.Id == id);
        }

        public override IQueryable<Customer> All()
        {
            return _context.Customers;
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
