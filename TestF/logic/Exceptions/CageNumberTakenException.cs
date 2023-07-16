using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class CageNumberTakenException : Exception
    {
        public CageNumberTakenException()
        {

        }

        public CageNumberTakenException(string message)
        : base(message)
        {
        }

        public CageNumberTakenException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
