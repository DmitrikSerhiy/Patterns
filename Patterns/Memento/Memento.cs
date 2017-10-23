using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
        public int _Health { get; private set; }
        public int _Stamina { get; private set; }
        public int _Ammo { get; private set; }

        public Memento(int Health, int Stamina, int Ammo)
        {
            _Health = Health;
            _Stamina = Stamina;
            _Ammo = Ammo;
        }
    }
}
