using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.VideoGamePlayers;

namespace Domain.CreatePlayers
{
    abstract class CreatePlayer
    {
        /// <summary>
        /// Создание персонажа
        /// </summary>
        abstract public VideoGamePlayer Create();
    }
}
