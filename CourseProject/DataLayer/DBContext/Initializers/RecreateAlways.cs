using System;
using System.Data.Entity;

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
