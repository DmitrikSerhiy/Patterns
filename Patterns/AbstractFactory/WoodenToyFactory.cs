using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WoodenToyFactory : IToyFactory
    {
        public Bear Bear => new Bear();
        public Cat Cat => new Cat();
    }
}
