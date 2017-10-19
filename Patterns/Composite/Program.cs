using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent root = new Component("Root");
            Component leaf1 = new Leaf("Leaf1");
            Component leaf2 = new Leaf("Leaf2");
            IComponent subRoot = new Component("Sub Root");
            subRoot.Add(leaf2);

            root.Add(leaf1);
            root.Display();

            Console.WriteLine("====");
            root.Add(subRoot);
            root.Display();
            Console.ReadKey();
            //it's basically the simplest realisation of tree structure through composite pattern
        }
    }
}
