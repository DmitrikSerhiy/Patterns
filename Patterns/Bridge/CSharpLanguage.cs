using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class CSharpLanguage : Language
    {
        public override void Build()
        {
            Console.WriteLine("build is compliting by csharp");
        }

        public override void Execute()
        {
            Console.WriteLine("execute is compliting by csharp");
        }
    }
}
