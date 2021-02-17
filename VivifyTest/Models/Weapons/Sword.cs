using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;
using VivifyTest.Models.Heroes;

namespace VivifyTest.Models.Weapons
{
    public class Sword : Weapon
    {
        public Sword(HeroEnum owner) : base(owner)
        {
            if (owner == HeroEnum.Wizard)
                throw new Exception("My owner cannot be wizard");
        }
    }
}
