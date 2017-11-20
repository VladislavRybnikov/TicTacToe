using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;
using TicTacToe.Entities;


namespace TicTacToe.Configurations
{
    public class FieldConfig
    {
        public static IGamePoint[,] points = new IGamePoint[,]
        {
            {
                new GamePoint(1,2),
                new GamePoint(1,6),
                new GamePoint(1,10)
            },
            {
                new GamePoint(3,2),
                new GamePoint(3,6),
                new GamePoint(3,10)
            },
            {
                new GamePoint(5,2),
                new GamePoint(5,6),
                new GamePoint(5,10)
            }
        };

        public static IGamePoint StartPoint = new GamePoint(25, 5);
        public static IGamePoint NamePoint = new GamePoint(26, 3);
        public static ConsoleColor[] colors =
            {
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.Red,
            ConsoleColor.DarkGray
        };
        public static int width = 13;
        public static int height = 7;

        
    } 
}
