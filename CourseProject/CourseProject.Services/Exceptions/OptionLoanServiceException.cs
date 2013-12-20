using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Services.Exceptions
{
    public class OptionLoanServiceException : ServiceException
    {
        protected OptionLoanServiceException()
        {

        }

        public OptionLoanServiceException(string message)
            : base(message)
        {

        }

        public OptionLoanServiceException(Exception exception)
            : base(exception)
        {

        }
    }
}
