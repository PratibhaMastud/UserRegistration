using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD,
            INVALID_EMAILLIST
        }

        private readonly ExceptionType type;
        public UserRegistrationException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
