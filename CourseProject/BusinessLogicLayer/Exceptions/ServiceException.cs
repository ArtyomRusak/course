using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Exceptions
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
