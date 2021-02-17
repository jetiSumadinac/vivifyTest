using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;
using VivifyTest.Models.Weapons;

namespace VivifyTest.Models.Heroes
{
    public class Swordsman : Hero
    {
        public Swordsman()
        {
            Health = 100;
        }

        public override void AddWeapon(WeaponsEnum weaponType)
        {
            if (Weapons.Count > Settings.MAX_WEAPON_NUM)
                throw new Exception(nameof(AddWeapon)+"Max weapon number reached");
            switch (weaponType)
            {
                case WeaponsEnum.Spear:
                    Weapons.Add(new Spear(HeroEnum.Swordsman));
                    break;
                case WeaponsEnum.Sword:
                    Weapons.Add(new Sword(HeroEnum.Swordsman));
                    break;
            }
        }
    }
}
