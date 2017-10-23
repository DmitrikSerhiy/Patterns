using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(ReceiverManager ReceiverManager)
        {
            if (ReceiverManager.BankPayment) Console.WriteLine("Bank payment is compliting");
            else Successor.Handle(ReceiverManager);
        }
    }
}
