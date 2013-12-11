using System;

namespace CourseProject.Services.Exceptions
{
    public class AccountServiceException : ServiceException
    {
        protected AccountServiceException()
        {

        }

        public AccountServiceException(string message)
            : base(message)
        {

        }

        public AccountServiceException(Exception exception)
            : base(exception)
        {

        }
    }
}
