using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Interfaces;
using TicTacToe.Interfaces.Logic;
using TicTacToe.Entities;
using TicTacToe.Configurations;

namespace TicTacToe
{
    public class GameProcessor : IGameProcessor
    {
        private int _currentX;
        private int _currentY;
        private char _currCh;

        public IGrid<char> CGrid { get; set; }

        public GameProcessor(IGrid<char> grid)
        {
            CGrid = grid;
            _currentX = 0;
            _currentY = 0;
        }

        public void Start()
        {
            Console.CursorVisible = false;
            ConsoleKey key;
            char symbol = CharHolder.inputSymbol;
            _currCh = CharHolder.O;
            IGamePoint currentPoint = FieldConfig.points[_currentX, _currentY];
            CGrid.Fields[currentPoint.X, currentPoint.Y] = symbol;
            CGrid.Redraw();
            
            while ((key = Console.ReadKey().Key) != ConsoleKey.E)
            {
                
                if (key == ConsoleKey.LeftArrow && _currentX > 0)
                    _currentX--;
                else if (key == ConsoleKey.RightArrow && _currentX < 2)
                    _currentX++;
                else if (key == ConsoleKey.DownArrow && _currentY < 2)
                    _currentY++;
                else if (key == ConsoleKey.UpArrow && _currentY > 0)
                    _currentY--;
                else if (key == ConsoleKey.Enter && CGrid.GetField(currentPoint) != CharHolder.X
                    && CGrid.GetField(currentPoint) != CharHolder.O)
                {
                    symbol = _currCh;
                    CurrChSwitch();
                }

                foreach (var point in FieldConfig.points)
                    if (CGrid.Fields[point.X, point.Y] != CharHolder.X
                        && CGrid.Fields[point.X, point.Y] != CharHolder.O)
                        CGrid.Fields[point.X, point.Y] = CharHolder.empty;

                currentPoint = FieldConfig.points[_currentY, _currentX];

                if(CGrid.Fields[currentPoint.X, currentPoint.Y] != CharHolder.X
                    && CGrid.Fields[currentPoint.X, currentPoint.Y] != CharHolder.O)
                    CGrid.Fields[currentPoint.X, currentPoint.Y] = symbol;

                
                CGrid.Redraw();
                symbol = CharHolder.inputSymbol;
                
                
            }
        }
        private void CurrChSwitch()
        {
            if (_currCh == CharHolder.O)
                _currCh = CharHolder.X;
            else
                _currCh = CharHolder.O;
        }
        private void Win()
        {
            IGamePoint[,] arr = FieldConfig.points;
        }

        public void Execute()
        {
            this.Start();
        }
        public override string ToString()
        {
            return "New Game";
        }
    }
}
