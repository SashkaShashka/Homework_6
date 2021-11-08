using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class TankOverflowException : Exception
    {
        public string Information { get; private set; }
        public TankOverflowException(string message, uint maxAddVolume) : base(message)
        {
            Information = ("Можно добавить только " + maxAddVolume + " литров");
        }
    }
}

