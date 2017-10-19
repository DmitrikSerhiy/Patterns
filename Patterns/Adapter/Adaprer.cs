using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adaprer : INewElectricitySystem
    {
        private readonly OldElecticitySystem OldElecticitySystem;
        public Adaprer(OldElecticitySystem _OldElecticitySystem)
        {
            OldElecticitySystem = _OldElecticitySystem;
        }
        public string MatchWideSocket()
        {
            return OldElecticitySystem.MatchThinSocket();
        }
    }
}
