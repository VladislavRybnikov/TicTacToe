using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;

namespace TicTacToe.Entities
{
    internal class GamePoint : IGamePoint
    { 
        public int X { get; set; }
        public int Y { get; set; }

        public GamePoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
