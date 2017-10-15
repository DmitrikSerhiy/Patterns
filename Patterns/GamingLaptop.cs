using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class GamingLaptop : LaptopBuilder
    {
        public override void SetMemory()
        {
            Laptop.Memory = "8000MB";
        }

        public override void SetBattery()
        {
            Laptop.Battery = "5000mAp";
        }

        public override void SetCPU()
        {
            Laptop.CPU = "coreI7";
        }

        public override void SetMonitor()
        {
            Laptop.Monitor = "1080p";
        }
    }
}
