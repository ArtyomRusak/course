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
    public class CurrencyRepository : Service<Currency>, ICurrencyRepository
    {
        #region [Private members]

        private BankContext _context;

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

        public override Currency GetEntityById(int id)
        {
            return _context.Currencies.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion
    }
}
