using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Entities;
using TicTacToe.Configurations;
using TicTacToe.GameLogic;
using TicTacToe.Interfaces.Logic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            TicTacToeProcessor processor = new TicTacToeProcessor();
            processor.Start();
        }
    }
}
