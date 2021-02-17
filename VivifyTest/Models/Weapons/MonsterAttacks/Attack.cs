using System;
using System.Collections.Generic;
using System.Text;
using VivifyTest.Helpers;

namespace VivifyTest.Models.Weapons.MonsterAttacks
{
    public abstract class Attack
    {
        public int Damage { get; set; }
        public AttackEnum AttackTypeEnum { get; internal set; }
        public class Punch : Attack{
            public Punch()
            {
                Damage = Settings.PUNCH_ATTACK_DAMAGE;
                AttackTypeEnum = AttackEnum.Punch;
            }
        }
        public class FireSpit : Attack{
            public FireSpit()
            {
                Damage = Settings.FIRESPIT_ATTACK_DAMAGE;
                AttackTypeEnum = AttackEnum.FireSpit;
            }
        }
        public class Bite : Attack
        {
            public Bite()
            {
                Damage = Settings.BITE_ATTACK_DAMAGE;
                AttackTypeEnum = AttackEnum.Bite;
            }
        }
    }
}
