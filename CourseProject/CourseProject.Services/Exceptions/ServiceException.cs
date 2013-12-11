using System;

namespace CourseProject.Services.Exceptions
{
    public class ServiceException : Exception
    {
        protected ServiceException()
        {

        }

        public ServiceException(string message)
            : base(message)
        {

        }

        public ServiceException(Exception ex)
            : base("See inner exception", ex)
        {

        }
    }
}
