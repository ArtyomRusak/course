using System;

namespace CourseProject.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Rollback();

        void PreSave();
    }
}
