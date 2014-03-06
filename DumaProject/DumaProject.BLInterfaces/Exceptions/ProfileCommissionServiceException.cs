using System;

namespace DumaProject.BLInterfaces.Exceptions
{
    public class ProfileCommissionServiceException : Exception
    {
        protected ProfileCommissionServiceException()
        {

        }

        public ProfileCommissionServiceException(string message)
            : base(message)
        {

        }

        public ProfileCommissionServiceException(Exception ex)
            : base("See inner exception", ex)
        {

        }
    }
}
