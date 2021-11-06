using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class TankOverflowException : Exception
    {
        public TankOverflowException(string message) : base(message) { }
    }
}
