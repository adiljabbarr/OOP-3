using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    internal class Player
    {
        public string Health { get; set; }
        public string Mana { get; set; }
        public string Inventory { get; set; }


        public void Attack()
        {
            Console.WriteLine("Player attacked these mobs:");
        }
        public void UseItem()
        {
            Console.WriteLine("Select the item you will use");
        }
    }
}
