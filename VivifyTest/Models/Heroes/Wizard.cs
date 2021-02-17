using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;

namespace VivifyTest.Models.Heroes
{
    public class Wizard : Hero
    {
        public Wizard()
        {
            Health = 150;
        }
        public override void AddWeapon(WeaponsEnum weaponType) {
            if (Weapons.Count > Settings.MAX_WEAPON_NUM)
                throw new Exception(nameof(AddWeapon) + "Max weapon number reached");
        }
    }
}
