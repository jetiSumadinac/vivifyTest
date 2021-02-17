using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Models.Weapons.MonsterAttacks;

namespace VivifyTest.Models.Monsters
{
    public abstract class Monster
    {
        public Attack Attack { get; set; }
    }
}
