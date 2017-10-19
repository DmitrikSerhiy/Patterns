using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class JavaLanguage : Language
    {
        public override void Build()
        {
            Console.WriteLine("build is compliting by java");
        }

        public override void Execute()
        {
            Console.WriteLine("execute is compliting by java");
        }
    }
}
