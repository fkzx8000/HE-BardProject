using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestF.logic.Exceptions
{
    class BirdIDException : Exception
    {
        public BirdIDException()
        {

        }

        public BirdIDException(string message)
        : base(message)
        {
        }

        public BirdIDException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
