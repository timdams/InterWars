using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterWars
{
    abstract class HouseholdItem
    {
        public int Price { get; set; }
    }

    class Table: HouseholdItem
    {

    }

    class Glass : HouseholdItem, IWeaponBehavior
    {
        private bool unbroken = true;
        public void Display()
        {
            Console.WriteLine("A glass");
        }

        public void UseWeapon()
        {
            if (unbroken)
            {
                Console.WriteLine("The glass shatters");
                unbroken = false;
            }
            else
            {
                Console.WriteLine("You cut yourself.Idiot");
            }
        }
    }
}
