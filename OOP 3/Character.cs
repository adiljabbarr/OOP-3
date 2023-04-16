using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_3
{
    abstract class Character
    {
        public string Name { set; get; }
        public string Health { set; get; }
        public string DamagePoint { set; get; }
        public string MovementSpeed { set; get; }

        public abstract void PlayerNew();
    }
    internal class Player1 : Character
    {
        public override void PlayerNew()
        {
            
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Damage: " + DamagePoint);
        }
    }

    internal class Enemy : Character
    {
        public override void PlayerNew()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Damage: " + DamagePoint);
        }
    }
}
