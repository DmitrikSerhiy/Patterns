using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ProgrammerSerg : Programmer
    {
        public ProgrammerSerg(Language language) : base(language)
        {
            
        }
        public override void DoWork()
        {
            Console.WriteLine("Serg is working");
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Serg earns money");
        }
    }
}
