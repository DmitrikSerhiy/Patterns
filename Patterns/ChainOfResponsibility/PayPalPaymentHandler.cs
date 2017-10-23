using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(ReceiverManager ReceiverManager)
        {
            if (ReceiverManager.PayPalPaymant) Console.WriteLine("PayPal payment is compliting");
            else Successor.Handle(ReceiverManager);
        }
    }
}
