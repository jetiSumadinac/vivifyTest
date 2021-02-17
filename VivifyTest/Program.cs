using System;
using VivifyTest.Models.Heroes;
using VivifyTest.Models.Weapons;

namespace VivifyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            testInitialize();
        }
        static void testInitialize() {
            var hero1 = new Swordsman();
            hero1.Weapons.Add(new Sword(hero1));
        }
    }
}
