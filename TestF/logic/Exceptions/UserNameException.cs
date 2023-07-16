using System;

namespace TestF.logic.Exceptions
{
    class UserNameException : Exception
    {
        public UserNameException()
        {

        }

        public UserNameException(string message)
        : base(message)
        {
        }

        public UserNameException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
