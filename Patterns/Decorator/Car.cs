using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Car
    {
        protected string Brend { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine($"{Brend} is driving");
        }
    }
}
