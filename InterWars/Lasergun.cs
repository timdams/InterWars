using System;

namespace InterWars
{
    class Lasergun : IWeaponBehavior
    {
        private int battery = 3;
        public void Display()
        {
            Console.WriteLine($"A lasergun. Battery left {battery}");
        }

        public void UseWeapon()
        {
            if (battery > 0)
            {
                battery--;
                Console.WriteLine("Pew pew pew");
            }
            else
                Console.WriteLine("Kliklik. Battery empty");
        }
        public void Reload()
        {
            battery = 3;
        }
    }
}
