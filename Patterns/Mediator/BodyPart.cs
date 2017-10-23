using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class BodyPart
    {
        private readonly Brain _brain;

        public BodyPart(Brain brain)
        {
            _brain = brain;
        }

        public void DoFunction()
        {
            _brain.CommitSmth(this);
        }
    }
}
