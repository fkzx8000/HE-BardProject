using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class SerialException : Exception
    {
        public SerialException()
        {

        }

        public SerialException(string message)
        : base(message)
        {
        }

        public SerialException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
