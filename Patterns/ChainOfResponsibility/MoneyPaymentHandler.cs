using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(ReceiverManager ReceiverManager)
        {
            if (ReceiverManager.MoneyPayment) Console.WriteLine("Money payment is compliting");
            else Successor.Handle(ReceiverManager);
        }
    }
}
