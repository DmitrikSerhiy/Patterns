using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class ReceiverManager
    {
        public bool BankPayment { get; set; }
        public bool MoneyPayment { get; set; }
        public bool PayPalPaymant { get; set; }

        public ReceiverManager(bool BP, bool MP, bool PPP)
        {
            BankPayment = BP;
            MoneyPayment = MP;
            PayPalPaymant = PPP;
        }
    }
}
