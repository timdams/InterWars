using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterWars
{
    class JediKnight: Character
    {
        public IWeaponBehavior secondWeaponBehaviour { get; set; } = new Lasergun();
        public override void Display()
        {
            Console.WriteLine("Ik ben een jedi knight");
        }

        public void SwitchWeapon()
        {
            IWeaponBehavior temp = WeaponBehavior;
            WeaponBehavior = secondWeaponBehaviour;
            secondWeaponBehaviour = temp;
        }

    }
}
