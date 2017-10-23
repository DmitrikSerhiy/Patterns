using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Car
    {
        public string _Name { get; private set; }

        public Car(string Name)
        {
            _Name = Name;
        }
    }
}
