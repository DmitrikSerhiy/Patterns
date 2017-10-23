using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Pult
    {
        private ICommand _command;

        public Pult(ICommand command)
        {
            _command = command;
        }
        public void PressDoButton()
        {
            _command.Execute();
        }

        public void PressUndoButton()
        {
            _command.Undo();
        }
    }
}
