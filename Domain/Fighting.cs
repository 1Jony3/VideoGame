using Domain.VideoGamePlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Fighting
    {
        public VideoGamePlayer attacking;
        public VideoGamePlayer defending;
        public Fighting(VideoGamePlayer attacking, VideoGamePlayer defending) {

            this.attacking = attacking;
            this.defending = defending;
            
        }

        public void Fight()
        {

        }

        public void Hit() 
        {
            //модификатор атаки
            int attackModifier = attacking.attack - defending.defense + 1;
        }
    }
}
