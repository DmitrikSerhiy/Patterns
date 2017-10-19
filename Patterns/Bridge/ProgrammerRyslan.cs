using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ProgrammerRyslan : Programmer
    {
        public ProgrammerRyslan(Language language) : base(language)
        {

        }
        public override void DoWork()
        {
            Console.WriteLine("Ryslan is working");
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Ryslan earns money");
        }
    }
}
