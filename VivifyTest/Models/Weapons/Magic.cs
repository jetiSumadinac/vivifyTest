using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;

namespace VivifyTest.Models.Weapons
{
    public class Magic : Weapon
    {

        public Magic(HeroEnum owner): base(owner)
        {
            if (owner == HeroEnum.Swordsman)
                throw new Exception("My owner cannot be swordsman");
        }
    }
}
