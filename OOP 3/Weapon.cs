using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    internal class Weapon
    {
        string name;
        int damage;
        
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
            
        }
    }

    class MagicalStaff : Weapon
    {
        public MagicalStaff(string name, int damage) : base(name, damage)
        {

        }
    }

    class BurningArrow : Weapon
    {
        public BurningArrow(string name, int damage) : base(name, damage)
        {

        }
    }

    class Smasher : Weapon
    {
        public Smasher(string name, int damage) : base(name, damage)
        {

        }
    }
}
