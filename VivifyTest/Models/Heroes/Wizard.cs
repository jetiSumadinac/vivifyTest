using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;
using VivifyTest.Models.Weapons;

namespace VivifyTest.Models.Heroes
{
    public class Wizard : Hero
    {
        public Wizard()
        {
            Health = 150;
        }
        public override void AddWeapon(Weapon weapon) {
            if (Weapons.Count > Settings.MAX_WEAPON_NUM)
                throw new Exception(nameof(AddWeapon) + "Max weapon number reached");
            
            if (weapon.WeaponEnum == WeaponsEnum.Sword)
                throw new Exception("I cannot take Sword as weapon!");
            else if (weapon.WeaponEnum == WeaponsEnum.Spear)
                throw new Exception("I cannot take spear as weapon!");
            else
                Weapons.Add(weapon);
        }
    }
}
