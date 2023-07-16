using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class UserPasswordExceptions : Exception
    {
        public UserPasswordExceptions()
        {

        }

        public UserPasswordExceptions(string message)
        : base(message)
        {
        }

        public UserPasswordExceptions(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
