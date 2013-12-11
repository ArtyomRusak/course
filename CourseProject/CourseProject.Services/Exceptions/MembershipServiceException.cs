using System;

namespace CourseProject.Services.Exceptions
{
    public class MembershipServiceException : ServiceException
    {
        protected MembershipServiceException()
        {

        }

        public MembershipServiceException(string message)
            : base(message)
        {

        }

        public MembershipServiceException(Exception exception)
            : base(exception)
        {

        }
    }
}
