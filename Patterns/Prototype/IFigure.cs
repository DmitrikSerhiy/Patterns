using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IFigure //it's prototype interface
    {
        IFigure Clone();
        void GetInfo();
    }
}
