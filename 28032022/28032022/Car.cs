using System;
using System.Collections.Generic;
using System.Text;

namespace _28032022
{
    internal class Car
    {
        public Car(int glbKm)
        {
            this.GlobalMillage = glbKm;
        }

        private string _model;
        public string Brand;

        public int GlobalMillage { get; private set; }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {

                if (!string.IsNullOrWhiteSpace(value) && value.Length > 2)
                {
                    foreach (var item in value)
                    {
                        if (char.IsDigit(item))
                            return;
                    }

                    _model = value;
                }
            }
        }

        public void Drive(int km)
        {
            this.GlobalMillage += km;
        }
    }
}
