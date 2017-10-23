using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    //careTaker
    public class GameHistory
    {
        public Stack<Memento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<Memento>();
        }
    }
}
