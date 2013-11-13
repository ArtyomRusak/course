using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DBContext;
using DataLayer.Repositories.Contracts;
using Entities;

namespace DataLayer.Repositories
{
    public class OptionDepositRepository : Service<OptionDeposit>, IOptionDepositRepository
    {
        #region [Private members]

        private BankContext _context;

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

        public override OptionDeposit GetEntityById(int id)
        {
            return _context.OptionDeposits.FirstOrDefault(e => e.Id == id);
        }

        public override void Save()
        {
            _context.SaveChanges();
        }

        #endregion
    }
}
