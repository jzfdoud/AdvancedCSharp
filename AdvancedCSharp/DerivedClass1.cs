using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp
{
    class DerivedClass1: Interface1
    {
        public void Print(string msg) { }
    }

    class DerivedClass2 : AbstractClass1
    {
        public override void Print(string msg) {
            Print();
                }
    }
}
