using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumaProject.BLInterfaces.Exceptions
{
    public class JournalServiceException : Exception
    {
        protected JournalServiceException()
        {

        }

        public JournalServiceException(string message)
            : base(message)
        {

        }

        public JournalServiceException(Exception ex)
            : base("See inner exception", ex)
        {

        }
    }
}
