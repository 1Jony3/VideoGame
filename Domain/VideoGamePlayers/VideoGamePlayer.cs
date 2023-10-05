using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VideoGamePlayers
{
    public abstract class VideoGamePlayer
    {
        Random r = new Random();

        //имя персонажа
        public abstract string Name { get; }
        //максимальное здоровье
        public int N;
        //левый порог урона
        public int M;
        //количество раз, которое можно исцелиться
        public int countHealth = 4;
        /* set => health += (int)(N * 0.3); */

        //атака
        public int attack;
        //защита
        public int defense;
        //здоровье
        public int health;
        //урон
        public int[] damage;

        public VideoGamePlayer()
        {
            this.N = r.Next(5, 50);
            this.M = r.Next(1, N - 1);
            this.attack = r.Next(1, 30);
            this.defense = r.Next(1, 30);
            this.health = r.Next(0, N);
            this.damage = Enumerable.Range(M, 6).ToArray();
        }       

        public bool CanBeHealed()
        {
            if (countHealth > 0) return true;
            else return false;
        }


    }

}
