using System;
using System.Data.Entity;

namespace CourseProject.EFData.DBContext.Initializers
{
    public class RecreateAlways : IDatabaseInitializer<BankContext>
    {
        #region Implementation of IDatabaseInitializer<in BankContext>

        public void InitializeDatabase(BankContext context)
        {
            context.Database.Delete();
            context.Database.Create();
            context.Database.ExecuteSqlCommand("ALTER TABLE Customers ADD CONSTRAINT PassportDataUnique UNIQUE (PassportData)");
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
