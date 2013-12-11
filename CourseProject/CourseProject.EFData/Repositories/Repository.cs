using CourseProject.Core.InterfaceRepository;
using CourseProject.EFData.DBContext;

namespace CourseProject.EFData.Repositories
{
    public class Repository : IRepository
    {
        protected BankContext Context;

        public Repository(BankContext context)
        {
            Context = context;
        }
    }
}
