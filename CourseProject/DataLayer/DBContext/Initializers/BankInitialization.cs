using System;
using System.Data.Entity;
using System.Transactions;

namespace DataLayer.DBContext.Initializers
{
    public class BankInitialization : IDatabaseInitializer<BankContext>
    {
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
                Seed(context);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Dispose();
                throw;
            }
        }

        public void Seed(BankContext context)
        {
            
        }
    }
}
