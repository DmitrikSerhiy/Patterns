using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IToyFactory
    {
        Bear Bear { get; }
        Cat Cat { get; }
    }
}
