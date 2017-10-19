using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiller compiller;
        CLR clr;
        public VisualStudioFacade(TextEditor te, Compiller compil, CLR clr)
        {
            this.textEditor = te;
            this.compiller = compil;
            this.clr = clr;
        }

        public void Start()
        {
            textEditor.WriteCode();
            textEditor.SaveCode();
            compiller.Compile();
            clr.Execute();
        }

        public void Stop()
        {
            clr.Finish();
        }
    }
}
