using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Brain
    {
        public Eye Eye { get; private set; }
        public Arm Arm { get; private set; }
        public Leg Leg { get; private set; }
        public Stomach Stomach{ get; private set; }


    public Brain()
        {
            CreateBodyPart();
        }
        private void CreateBodyPart()
        {
            Eye = new Eye(this);
            Arm = new Arm(this);
            Leg = new Leg(this);
            Stomach = new Stomach(this);
        }

        public void CommitSmth(BodyPart bodyPart)
        {
            if (bodyPart is Eye) { (bodyPart as Eye).Blink(); }
            else if (bodyPart is Leg)
            {
                (bodyPart as Leg).Jump();
            }
            else if (bodyPart is Arm)
            {
                (bodyPart as Arm).Raise();
            }
            else if(bodyPart is Stomach)
            {
                (bodyPart as Stomach).Work();
            }
            else Console.WriteLine("there is no such part of body");
        }
    }
}
