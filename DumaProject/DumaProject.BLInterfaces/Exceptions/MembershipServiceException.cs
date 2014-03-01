using System;

namespace DumaProject.BLInterfaces.Exceptions
{
    public class MembershipServiceException : Exception
    {
        protected MembershipServiceException()
        {

        }

        public MembershipServiceException(string message)
            : base(message)
        {

        }

        public MembershipServiceException(Exception ex)
            : base("See inner exception", ex)
        {

        }
    }
}
