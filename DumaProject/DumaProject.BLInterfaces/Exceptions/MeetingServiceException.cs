using System;

namespace DumaProject.BLInterfaces.Exceptions
{
    public class MeetingServiceException : Exception
    {
        protected MeetingServiceException()
        {

        }

        public MeetingServiceException(string message)
            : base(message)
        {

        }

        public MeetingServiceException(Exception ex)
            : base("See inner exception", ex)
        {

        }
    }
}
