using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Services.Exceptions
{
    public class OptionDepositServiceException : ServiceException
    {
        protected OptionDepositServiceException()
        {

        }

        public OptionDepositServiceException(string message)
            : base(message)
        {

        }

        public OptionDepositServiceException(Exception exception)
            : base(exception)
        {

        }
    }
}
