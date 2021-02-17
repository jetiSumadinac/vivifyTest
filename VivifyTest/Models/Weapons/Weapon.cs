using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;

namespace VivifyTest.Models.Weapons
{
    public abstract class Weapon
    {
        public bool IsActive { get; set; }
        public Type Owner { get; set; }
        public Weapon(HeroEnum owner)
        {

        }
    }
}
