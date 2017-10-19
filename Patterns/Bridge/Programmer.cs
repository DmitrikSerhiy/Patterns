using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Programmer
    {
        public Language language;
        public Language Language { set { language = value; } }

        public Programmer(Language _language)
        {
            language = _language;
        }

        public virtual void DoWork()
        {
            Console.WriteLine("working...");
        }

        public virtual void EarnMoney()
        {
            Console.WriteLine("earninng money...");
        }
    }
}
