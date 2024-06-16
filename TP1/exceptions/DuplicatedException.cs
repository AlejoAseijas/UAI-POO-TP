using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Exceptions
{
    public class DuplicatedException : Exception
    {
        public DuplicatedException(string message) : base(message) { }

    }
}
