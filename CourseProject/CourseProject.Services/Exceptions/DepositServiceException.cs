using System;

namespace CourseProject.Services.Exceptions
{
    public class DepositServiceException : ServiceException
    {
        protected DepositServiceException()
        {

        }

        public DepositServiceException(string message)
            : base(message)
        {

        }

        public DepositServiceException(Exception exception)
            : base(exception)
        {

        }
    }
}
