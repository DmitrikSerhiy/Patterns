using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class TVOnCommand : ICommand
    {

        private TV _tv;
        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}
