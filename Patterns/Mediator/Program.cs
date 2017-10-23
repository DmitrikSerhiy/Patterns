using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Brain brain = new Brain();
            //we have incapsulated all the code in one class by using mediator

            (brain.Stomach as BodyPart).DoFunction();
            (brain.Leg as BodyPart).DoFunction();
            (brain.Eye as BodyPart).DoFunction();
            (brain.Arm as BodyPart).DoFunction();


            Console.ReadKey();
        }
    }
}
