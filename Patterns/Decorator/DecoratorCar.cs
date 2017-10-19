using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DecoratorCar : Car
    {
        protected Car DecoratedCar { get; set; }
        public DecoratorCar(Car carDecorator)
        {
            DecoratedCar = carDecorator;
        }
        public override void Drive()
        {
            DecoratedCar.Drive();
        }
    }
}
