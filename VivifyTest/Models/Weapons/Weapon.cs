using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;
using VivifyTest.Models.Interfaces.Generic;

namespace VivifyTest.Models.Weapons
{
    public abstract class Weapon
    {
        public bool IsActive { get; set; }
        public WeaponsEnum WeaponEnum { get; internal set; }
        public int Damage { get; internal set; }
    }
}
