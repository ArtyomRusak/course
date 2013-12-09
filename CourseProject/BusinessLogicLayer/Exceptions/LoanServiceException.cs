using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Exceptions
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
