using System;
using System.Collections.Generic;
using System.Text;

namespace _28032022
{
    internal class Employee:Human
    {
        public Employee(byte age,string bornCity):base(bornCity)
        {
            if (age > 18)
                this._age = age;
        }
        public string Position;

    }
}
