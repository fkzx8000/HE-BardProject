using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class IDException : Exception
    {
        public IDException()
        {

        }

        public IDException(string message)
        : base(message)
        {
        }

        public IDException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
