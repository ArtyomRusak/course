using System;

namespace CourseProject.Services.Exceptions
{
    public class LoanServiceException : ServiceException
    {
        protected LoanServiceException()
        {

        }

        public LoanServiceException(string message)
            : base(message)
        {

        }

        public LoanServiceException(Exception exception)
            : base(exception)
        {

        }
    }
}
