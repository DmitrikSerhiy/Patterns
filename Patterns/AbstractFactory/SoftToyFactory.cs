using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SoftToyFactory : IToyFactory
    {
        public Bear Bear => new Bear();
        public Cat Cat => new Cat();
    }
}
