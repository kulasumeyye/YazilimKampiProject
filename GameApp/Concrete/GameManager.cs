using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    class GameManager : IGameService
    {
        public void add(Game game)
        {
            Console.WriteLine("Game is added");
        }
    }
}
