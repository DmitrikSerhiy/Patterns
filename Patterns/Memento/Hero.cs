using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    //Originator
    public class Hero
    {
        private int Health = 100;
        private int Stamina = 50;
        private int Ammo = 10;

        public void Shoot()
        {
            if (Ammo > 0)
            {
                Ammo--;
                Console.WriteLine($"Shoot! Ka-boom! current ammo: {Ammo} ");
            }
            else
            {
                Console.WriteLine("No ammo!");
            }
        }
        public void Run()
        {
            
            if (Stamina > 0)
            {
                Stamina -= 5;
            }
            else
            {
                Console.WriteLine($"Can't run any more! Current stamina {Stamina}");
            }
        }
        public void GetShoot()
        {
            if(Health > 20)
            {
                Health -= 20;
                Console.WriteLine($"Current health {Health}");
            }
            else
            {
                Console.WriteLine("Game over!");
            }
        }

        public Memento SaveState()
        {
            Console.WriteLine("Saving...");
            return new Memento(Health, Stamina, Ammo);
        }
        
        public void RestoreState(Memento state)
        {
            this.Health = state._Health;
            this.Stamina = state._Stamina;
            this.Ammo = state._Ammo;
            Console.WriteLine("Restoring...");
        }
    }
}
