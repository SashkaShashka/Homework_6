using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class AlreadyExistsException : Exception
    {
        public string Value { get; private set; }
        public int Position { get; private set; }
        public AlreadyExistsException(string value, int position)
        {
            Value = value;
            Position = position;
        }
    }
}
