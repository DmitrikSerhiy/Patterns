using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();
            
            VisualStudioFacade vs = new VisualStudioFacade(textEditor, compiller, clr);

            vs.Start();
            vs.Stop();
            //So, instead of calling all the methods from appropriate classes 
            //call all these from one common interface (class VisualStudioFacade in this case
            Console.ReadKey();
        }
    }
}
