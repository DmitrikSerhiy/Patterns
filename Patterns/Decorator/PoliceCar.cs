using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class PoliceCar : DecoratorCar
    {
        public PoliceCar(Car _decoratedCar) : base(_decoratedCar)
        {

        }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("It's some extra features in police car");
        }
    }
}
