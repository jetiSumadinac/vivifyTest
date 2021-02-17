using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VivifyTest.Exceptions;
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

        public override void AddWeapon(Weapon weapon)
        {
            if (Weapons.Count > Settings.MAX_WEAPON_NUM)
                throw new Exception(nameof(AddWeapon)+"Max weapon number reached");
            if (weapon.WeaponEnum == WeaponsEnum.Magic)
                throw new Exception("I cannot take magic as weapon!");
            else
                Weapons.Add(weapon);
        }
        public override void ChangeWeapon() //TODO: repeatable code alert!!!!
        {
            if (Weapons.Count == 0)
                throw new NoWeaponException();
            var newWeapon = Weapons.FirstOrDefault(w => !w.IsActive);
            newWeapon.IsActive = true;
            ActiveWeapon = newWeapon;
        }

        public override void DropWeapon() //TODO: these methods should be extended
        {
            throw new NotImplementedException();
        }
    }
}
