using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class LaptopBuilder
    {
        protected Laptop Laptop { get; private set; }

        public void CreateNewLaptop()
        {
            Laptop = new Laptop();
        }

        public Laptop GetLaptop()
        {
            return Laptop;
        }

        public abstract void SetBattery();
        public abstract void SetCPU();
        public abstract void SetMonitor();
        public abstract void SetMemory();
    }
}
