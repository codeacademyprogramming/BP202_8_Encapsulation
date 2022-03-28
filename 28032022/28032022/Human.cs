using System;
using System.Collections.Generic;
using System.Text;

namespace _28032022
{
    internal class Human
    {
        public Human(string city)
        {
            BornCity = city;
        }
        public string FullName;
        protected byte _age = 10;

        public string GetInfo()
        {
            return $"Fullname: {this.FullName} - Age: {this._age}";
        }

        public string BornCity { get; private set; }

        public byte Age {
            get
            {
                return this._age;
            }
            set
            {
                if (value >= 10)
                    this._age = value;
            }
         }

        public void AgeSetter(byte age)
        {
            if(age>=18)
                this._age = age;
        }
        public byte AgeGetter()
        {
            return this._age;
        }

        public void BornCitySetter(string str)
        {
            this.BornCity = str;
        }
    }
}
