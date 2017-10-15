using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class BuyLaptop
    {
        private LaptopBuilder builder;
        public BuyLaptop(LaptopBuilder _builder)
        {
            builder = _builder;
        }

        public Laptop GetLaptop()
        {
            return builder.GetLaptop();
        }

        public void BuildLaptop()
        {
            builder.CreateNewLaptop();
            builder.SetBattery();
            builder.SetMemory();
            builder.SetCPU();
            builder.SetMonitor();
        }
    }
}
