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
    public class HistoryRepository : Service<History>, IHistoryRepository
    {
        #region [Private members]

        private readonly BankContext _context;

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
            return _context.Histories.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion


        #region Implementation of IHistoryRepository

        public List<History> GetHistoriesByCustomerId(int id)
        {
            return _context.Histories.Where(e => e.CustomerId == id).ToList();
        }

        #endregion
    }
}
