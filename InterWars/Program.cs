using System;
using System.Collections.Generic;

namespace InterWars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> units = new List<Character>();
            units.Add(new Stormtrooper());
            units.Add(new Stormtrooper() {WeaponBehavior = new Lasergun() });
            units.Add(new Stormtrooper(){WeaponBehavior = new Glass() });
            units.Add(new RebelSoldier() { WeaponBehavior = new Lasergun() });
            units.Add(new JediKnight() { WeaponBehavior = new Lightsaber() });

            foreach (var unit in units)
            {
                unit.Fight();
            }

            foreach (var unit in units)
            {
                unit.Fight();
            }
        }
    }
}
