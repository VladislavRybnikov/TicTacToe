using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;
using TicTacToe.Interfaces.Logic;
using TicTacToe.Configurations;

namespace TicTacToe.Entities
{
    internal class Grid : IGrid<char>
    {
        public char[,] Fields { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public IGamePoint StartPosition { get; set; }

        public Grid(IGamePoint startPosition)
        {
            Width = FieldConfig.width;
            Height = FieldConfig.height;
            Fields = new char[Height, Width];
            StartPosition = startPosition;
            GetCharGrid();
        }

        public void Redraw()
        {
            ConsoleGraphic.DrawTicTacToe(new GamePoint(StartPosition.X + 1, StartPosition.Y - 2));
            for (int i = StartPosition.Y; i < Height + StartPosition.Y; i ++)
            {
                Console.SetCursorPosition(StartPosition.X, i);
                for (int j = 0; j < Width; j++) {
                    if (Fields[i - StartPosition.Y, j] == CharHolder.X)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (Fields[i - StartPosition.Y, j] == CharHolder.O)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(Fields[i - StartPosition.Y, j]);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                Console.WriteLine();
            }
        }
        public char GetField(IGamePoint point)
        {
            return this.Fields[point.X, point.Y];
        }
        private void GetCharGrid()
        {
            bool IfNull(int a){ return a == 0; }    
            bool DivBy(int a, int by){ return a % by == 0;}
            bool Twice(bool a, bool b) { return a && b; }

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (IfNull(i) || DivBy(i, 2))
                        Fields[i, j] = '-';
                    if (IfNull(j) || DivBy(j, 4))
                        Fields[i, j] = '|';
                    if (Twice(IfNull(i), IfNull(j)) || Twice(DivBy(i, 2), DivBy(j, 4)))
                        Fields[i, j] = '+';
                }
            }
        }
        
    }
}
