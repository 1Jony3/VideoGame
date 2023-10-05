using Domain.CreatePlayers;
using Domain.CreatePlayers.Players;
using Domain.VideoGamePlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Client
    {
        public void Main()
        {
            CreatePlayer player = new CreateHero();
            VideoGamePlayer hero = player.Create();

            player = new CreateMonster();
            VideoGamePlayer monster = player.Create();

            Fighting fighting = new Fighting(hero, monster);
            fighting.Fight();

            Console.ReadLine();
        }
    }
}
