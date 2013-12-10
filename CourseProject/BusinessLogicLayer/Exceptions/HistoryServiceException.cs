using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Exceptions
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
