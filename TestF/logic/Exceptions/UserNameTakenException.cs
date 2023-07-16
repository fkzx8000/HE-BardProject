using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class UserNameTakenException : Exception
    {
        public UserNameTakenException()
        {

        }

        public UserNameTakenException(string message)
        : base(message)
        {
        }

        public UserNameTakenException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
