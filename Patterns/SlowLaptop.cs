using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class SlowLaptop : LaptopBuilder
    {
        public override void SetMemory()
        {
            Laptop.Memory = "2000MB";
        }

        public override void SetBattery()
        {
            Laptop.Battery = "3000mAp";
        }

        public override void SetCPU()
        {
            Laptop.CPU = "coreI3";
        }

        public override void SetMonitor()
        {
            Laptop.Monitor = "720p";
        }
    }
}
