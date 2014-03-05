using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumaProject.BLInterfaces.Exceptions
{
    public class CommissionServiceException : Exception
    {
        protected CommissionServiceException()
        {

        }

        public CommissionServiceException(string message)
            : base(message)
        {

        }

        public CommissionServiceException(Exception ex)
            : base("See inner exception", ex)
        {

        }
    }
}
