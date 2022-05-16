using System;

namespace InterWars
{
    abstract class Character
    {

        private IWeaponBehavior weaponBehavior = null;

        public IWeaponBehavior WeaponBehavior
        {
            get { return weaponBehavior; }
            set { weaponBehavior = value; }
        }

        public void Fight()
        {
            if (WeaponBehavior != null)
                WeaponBehavior.UseWeapon();
            else
                Console.WriteLine("Help. I have no weapon");
        }

        abstract public void Display();
    }
}
