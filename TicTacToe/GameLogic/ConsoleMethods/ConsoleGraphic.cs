using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Configurations;

namespace TicTacToe.Entities
{
    internal static class ConsoleGraphic
    {
        internal static void DrawTicTacToe(GamePoint startPosition)
        {
            Console.SetCursorPosition(startPosition.X, startPosition.Y);
            for (int i = 0; i < CharHolder.TicTacToe.Length; i++)
            {
                DrawSmth(CharHolder.TicTacToe[i], FieldConfig.colors[i]);
                if(i < CharHolder.TicTacToe.Length - 1)
                    DrawSpace();
            }
        }
        private static void DrawSpace()
        {
            DrawSmth(CharHolder.inputSymbol.ToString(), ConsoleColor.Gray);
        }
        internal static void DrawSmth(string smth, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(smth);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        
    }
}
