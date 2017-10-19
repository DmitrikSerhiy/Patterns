using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class NewElectricitySystem : INewElectricitySystem
    {
        public string MatchWideSocket()
        {
            return "220V";
        }
    }
}
