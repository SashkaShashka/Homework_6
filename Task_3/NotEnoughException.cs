using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class NotEnoughException : Exception
    {
        public NotEnoughException(string message) : base(message) { }
    }
}
