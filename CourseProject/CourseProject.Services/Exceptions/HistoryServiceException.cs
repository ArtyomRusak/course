using System;

namespace CourseProject.Services.Exceptions
{
    public class HistoryServiceException : ServiceException
    {
        protected HistoryServiceException()
        {

        }

        public HistoryServiceException(string message)
            : base(message)
        {

        }

        public HistoryServiceException(Exception ex)
            : base(ex)
        {

        }
    }
}
