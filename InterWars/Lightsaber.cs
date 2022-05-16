using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterWars
{
    class Lightsaber : IWeaponBehavior
    {
        public void Display()
        {
            Console.WriteLine("A lightsabre. From a more civilized time.");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Zoom zoom. Another limb off.");
        }
    }
}
