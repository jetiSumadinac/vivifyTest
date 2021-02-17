using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;

namespace VivifyTest.Models.Weapons
{
    public class Spear : Weapon
    {
        public Spear(HeroEnum owner) : base(owner)
        {
            if (owner == HeroEnum.Wizard)
                throw new Exception("My owner cannot be wizard");
        }

    }
}
