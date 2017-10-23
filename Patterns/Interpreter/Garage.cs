using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Garage : IEnumerable
    {
        private Car[] cars;
        private int size = 0;

        public Garage(int count)
        {
            cars = new Car[count];
        }

        public void MoveCarToGarage(Car car)
        {
            if (size < cars.Length)
            {
                cars[size] = car;
                size++;
                Console.WriteLine($"{car._Name} is moved to Garage");
            }
            else { Console.WriteLine("Garage is full"); }
        }

        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();

            //both examples are correct 
            //first for more simple implementation
            //second may be modificated by adding some other code inside cycle


            //foreach (Car car in cars)
            //{
            //    yield return car;
            //}
            
        }
    }
}
