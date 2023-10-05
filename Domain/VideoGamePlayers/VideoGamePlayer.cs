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

        /// <summary>
        /// Имя персонажа
        /// </summary>
        public abstract string Name { get; }
        //максимальное здоровье
        private int N;
        //левый порог урона
        private int M;
        //количество раз, которое можно исцелиться
        private int countHealth = 4;
        /* set => health += (int)(N * 0.3); */

        /// <summary>
        /// Параметр атаки
        /// </summary>
        public int attack;
        /// <summary>
        /// Параметр защиты
        /// </summary>
        public int defense;
        /// <summary>
        /// Параметр здоровья
        /// </summary>
        public int health;
        /// <summary>
        /// Параметр урона
        /// </summary>
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
        /// <summary>
        /// Функция, определяющая, может ли персонаж исцелиться
        /// </summary>
        public bool CanBeHealed()
        {
            if (countHealth > 0) return true;
            else return false;
        }
        /// <summary>
        /// Функция исцеления
        /// </summary>
        public void Heal()
        {
            int healing = (int)(N * 0.3);
            Console.WriteLine("исцеление на " + healing.ToString() + "здоровье = " + this.health.ToString());
            this.health += healing;
            this.countHealth--;
        }
    }

}
