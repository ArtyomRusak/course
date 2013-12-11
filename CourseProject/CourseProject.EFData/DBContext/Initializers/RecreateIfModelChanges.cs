using System;
using System.Data.Entity;
using System.Transactions;

namespace CourseProject.EFData.DBContext.Initializers
{
    public class RecreateIfModelChanges : IDatabaseInitializer<BankContext>
    {
        #region Implementation of IDatabaseInitializer<in BankContext>

        public void InitializeDatabase(BankContext context)
        {
            bool databaseExists;
            using (new TransactionScope(TransactionScopeOption.Suppress))
            {
                databaseExists = context.Database.Exists();
            }
            if (databaseExists)
            {
                if (context.Database.CompatibleWithModel(true))
                {
                    return;
                }
                context.Database.Delete();
            }
            context.Database.Create();
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Dispose();
                throw;
            }
        }

        #endregion
    }
}
