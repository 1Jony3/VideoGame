using Domain.VideoGamePlayers.Players;
using Domain.VideoGamePlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CreatePlayers.Players
{
    internal class CreateHero : CreatePlayer
    {
        public override VideoGamePlayer Create()
        {
            return new Hero();
        }
    }
}
