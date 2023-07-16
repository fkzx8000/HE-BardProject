using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class CageMissingException : Exception
    {
        public CageMissingException()
        {

        }

        public CageMissingException(string message)
        : base(message)
        {
        }

        public CageMissingException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
