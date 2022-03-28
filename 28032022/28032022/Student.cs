using System;
using System.Collections.Generic;
using System.Text;

namespace _28032022
{
    internal class Student
    {
        private string _groupNo;
        public string FullName;

        public string GroupNo
        {
            get
            {
                return this._groupNo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 5)
                    this._groupNo = value;
            }
        }
    }
}
