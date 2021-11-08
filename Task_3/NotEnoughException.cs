using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class NotEnoughException : Exception
    {
        public string Information { get; private set; }
        public NotEnoughException(string message, uint maxTakeVolume) : base(message) 
        {
            Information = ("Можно слить только " + maxTakeVolume + " литров");
        }
    }
}
