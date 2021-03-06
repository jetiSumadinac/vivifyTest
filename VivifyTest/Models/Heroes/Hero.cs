﻿using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;
using VivifyTest.Models.Weapons;

namespace VivifyTest.Models.Heroes
{
    public abstract class Hero
    {
        public int Health { get; set; }
        public Weapon ActiveWeapon { get; set; }
        public List<Weapon> Weapons { get; private set; }
        public Hero()
        {
            Weapons = new List<Weapon>();
            Weapons.Capacity = Settings.MAX_WEAPON_NUM;
        }

        public abstract void AddWeapon(Weapon weapon);//TODO: not so smart idea, I have to reference a real owner
        public abstract void ChangeWeapon();
        public abstract void DropWeapon();
    }
}
