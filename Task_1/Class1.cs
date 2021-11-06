using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Class1
    {
        public delegate Class1 GetNewClass1();
        public delegate Class1 TransformClass1(object obj);
        public delegate string GetClass1Description(object obj, string comment);

        private GetNewClass1 Generator;
        private TransformClass1 Transformer;

        public Class1(GetClass1Description d1, GetClass1Description d2)
        {
            OnDescribe += d1;
            OnDescribe += d2;
        }

        public event GetClass1Description OnDescribe;
    }
}
