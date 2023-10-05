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
        public string Name { get; }
        //максимальное здоровье
        public int N => r.Next(5, 50);
        //левый порог урона
        public int M => r.Next(1, N - 1);
        //количество раз, которое можно исцелиться
        public int countHealth => 4;


        //атака
        public int attack => r.Next(1, 30);
        //защита
        public int defense => r.Next(1, 30);
        //здоровье
        public int health 
    get => r.Next           set => health += (int)(N * 0.3); 
        }
        //урон
        public int[] damage => Enumerable.Range(M, 6).ToArray(); 

        public bool CanBeHealed()
        {
            if (countHealth > 0) return true;
            else return false;
        }


    }

}
