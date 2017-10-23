using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Pult pult = new Pult(new TVOnCommand(tv));
            pult.PressDoButton();
            pult.PressUndoButton();
            Console.ReadKey();
            //pult can send any command to tv at the same time pult know nothing about just like tv 
            //know nothing about pult
            //thus we have flexible system where all the commands are stored in one class
        }
    }
}
