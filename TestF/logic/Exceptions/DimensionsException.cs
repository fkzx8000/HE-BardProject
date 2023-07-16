using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class DimensionsException : Exception
    {
        public DimensionsException()
        {

        }

        public DimensionsException(string message)
        : base(message)
        {
        }

        public DimensionsException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
