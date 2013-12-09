using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Exceptions
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
