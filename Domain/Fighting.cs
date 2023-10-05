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
        private Random r = new Random();
        private bool attack = false;
        public Fighting(VideoGamePlayer attacking, VideoGamePlayer defending) {

            this.attacking = attacking;
            this.defending = defending;
            Fight();
        }

        public void Fight()
        {
            Console.WriteLine(attacking.Name + " аттакует " + defending.Name);
            //число на кубике
            int diceRoll = 0;
            //модификатор атаки
            int attackModifier = attacking.attack - defending.defense + 1;
            if (attackModifier <= 0) attackModifier = 1;
            Console.WriteLine("Количество кубиков, которые надо бросить = " + attackModifier.ToString());

            while (attackModifier > 0)
            {
                diceRoll = r.Next(1, 6);
                Console.WriteLine("Кубик брошен, выпало = " + diceRoll.ToString());
                if (diceRoll >= 5) attack = true;
                attackModifier -= 1;
            }

            if (attack == true)
            {
                Console.WriteLine("Удар успешен!!!, происходит удар");
                    Hit();
            }
            else Console.WriteLine("Удар не успешен!!!, игроки меняются местами");
        }

        public void Hit() 
        {
            int randomDamage = r.Next(0, attacking.damage.Length);
            Console.WriteLine("У " + defending.Name + " вычитаются из здоровья [" + defending.health.ToString() +
                "] -> количество очков " + attacking.damage[randomDamage].ToString());
            defending.health -= attacking.damage[randomDamage];
            
        }
    }
}
