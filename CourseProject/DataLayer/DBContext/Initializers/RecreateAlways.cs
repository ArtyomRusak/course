using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBContext.Initializers
{
    public class RecreateAlways : IDatabaseInitializer<BankContext>
    {
        #region Implementation of IDatabaseInitializer<in BankContext>

        public void InitializeDatabase(BankContext context)
        {
            context.Database.Delete();
            context.Database.Create();
            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {
                context.Dispose();
                throw;
            }
        }

        #endregion
    }
}
