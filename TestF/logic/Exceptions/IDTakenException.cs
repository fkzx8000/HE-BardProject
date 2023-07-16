using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class IDTakenException : Exception
    {
        public IDTakenException()
        {

        }

        public IDTakenException(string message)
        : base(message)
        {
        }

        public IDTakenException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
