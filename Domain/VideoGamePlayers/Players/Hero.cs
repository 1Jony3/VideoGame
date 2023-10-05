using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VideoGamePlayers.Players
{
    class Hero : VideoGamePlayer
    {
        public override string Name => "Hero";
        public Hero(): base()
        {
            Console.WriteLine(Name + "[");
            Console.WriteLine("Attack = " + attack);
            Console.WriteLine("Defense = " + defense);
            Console.WriteLine("Health = " + health);
            Console.WriteLine("Damage = ");
            foreach (var item in damage)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("]");
        }
    }
}
