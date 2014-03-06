using System;

namespace DumaProject.BLInterfaces.Exceptions
{
    public class ProfileMemberServiceException : Exception
    {
        protected ProfileMemberServiceException()
        {

        }

        public ProfileMemberServiceException(string message)
            : base(message)
        {

        }

        public ProfileMemberServiceException(Exception ex)
            : base("See inner exception", ex)
        {

        }
    }
}
