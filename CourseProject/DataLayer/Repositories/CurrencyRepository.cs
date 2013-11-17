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
    public class CurrencyRepository : Service<Currency>, ICurrencyRepository
    {
        #region [Private members]

        private readonly BankContext _context;

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
            return _context.Currencies.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion
    }
}
  