using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Exceptions
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
